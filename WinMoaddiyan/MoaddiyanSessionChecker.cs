using Newtonsoft.Json;
using RSecurityBackend.Models.Auth.Memory;
using RSecurityBackend.Models.Auth.ViewModels;
using System.Net.Http.Headers;
using System.Net;

namespace WinMoaddiyan
{
    public class MoaddiyanSessionChecker
    {
        /// <summary>
        /// if user is logged in adds user token to <paramref name="secureClient"/> and then checks user session and if needs renewal, renews it
        /// </summary>
        /// <param name="secureClient"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static async Task<bool> PrepareClientAsync(HttpClient secureClient)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.Token) || Properties.Settings.Default.SessionId == Guid.Empty)
                return false;
            secureClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Properties.Settings.Default.Token);
            var r = await secureClient.GetAsync($"https://api.moaddiyan.com/api/users/checkmysession/?sessionId={Properties.Settings.Default.SessionId}");
            if (r.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            else
            if (r.StatusCode == HttpStatusCode.Unauthorized)
            {
                var reLoginUrl = $"https://api.moaddiyan.com/api/users/relogin/{Properties.Settings.Default.SessionId}";
                var reLoginResponse = await secureClient.PutAsync(reLoginUrl, null);
                if (reLoginResponse.StatusCode != HttpStatusCode.OK)
                {
                    return false;
                }

                var json = await reLoginResponse.Content.ReadAsStringAsync();
                LoggedOnUserModel? loggedOnUser = JsonConvert.DeserializeObject<LoggedOnUserModel>(json);
                if (loggedOnUser != null)
                {
                    secureClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", loggedOnUser.Token);
                    
                    Properties.Settings.Default.LoggenOnUserJson = json;
                    Properties.Settings.Default.Token = loggedOnUser.Token;
                    Properties.Settings.Default.SessionId = loggedOnUser.SessionId;
                    Properties.Settings.Default.Save();
                }
                return true;

            }
            return false;
        }

        /// <summary>
        /// has permission
        /// </summary>
        /// <param name="secuableShortName"></param>
        /// <param name="operationShortName"></param>
        /// <returns></returns>
        public static async Task<bool> IsPermittedAsync(string secuableShortName, string operationShortName)
        {

            using (HttpClient secureClient = new HttpClient())
            {
                if (await PrepareClientAsync(secureClient))
                {
                    var res = await secureClient.GetAsync($"https://api.moaddiyan.com/api/users/securableitems");
                    if (!res.IsSuccessStatusCode)
                    {
                        return false;
                    }

                    SecurableItem[]? secuarbleItems = JsonConvert.DeserializeObject<SecurableItem[]>(await res.Content.ReadAsStringAsync());
                    if (secuarbleItems != null)
                    {
                        var secuarbleItem = secuarbleItems.Where(s => s.ShortName == secuableShortName).SingleOrDefault();

                        if (secuarbleItem == null)
                            return false;

                        var operation = secuarbleItem.Operations.Where(o => o.ShortName == operationShortName).SingleOrDefault();
                        if (operation == null)
                            return false;

                        return operation.Status;
                    }
                    return false;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
