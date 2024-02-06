using Netick;

namespace StinkySteak.Netick.Util
{
    public static class NetworkPlayerExtension
    {
        /// <summary>
        /// Convert <see cref="NetworkPlayer.PlayerId"/> to InputSourcePlayerId
        /// </summary>
        public static int GetInputSourcePlayerId(this NetworkPlayer networkPlayer)
        {
            if (networkPlayer.PlayerId == 0)
                return -2;

            return networkPlayer.PlayerId - 1;
        }
    }
}