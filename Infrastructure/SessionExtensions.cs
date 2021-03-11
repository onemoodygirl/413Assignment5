using System;
using Microsoft.AspNetCore.Http;
using System.Text.Json;

namespace MoodyAssignment5.Infrastructure
{
    //This is a tool to convert our Cart onject to a Json (string) file,
        //then back, bc we can't store carts in a session

    public static class SessionExtensions
    {
        public static void SetJson (this ISession session, string key, object value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T GetJson<T> (this ISession session, string key)
        {
            var sessionData = session.GetString(key);

            return sessionData == null ? default(T) : JsonSerializer.Deserialize<T>(sessionData);
        }
    }
}
