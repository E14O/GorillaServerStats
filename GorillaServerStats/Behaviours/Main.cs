using GorillaNetworking;
using GorillaServerStats.Tools;
using UnityEngine;

namespace GorillaServerStats.Behaviours
{
    public class Main : MonoBehaviour
    {
        void Update()
        {
            if (TextFinder.Instance._HeaderText == null)
                return;

            if (TextFinder.Instance._BodyText == null)
                return;

            TextFinder.Instance._HeaderText.text = "GORILLA SERVER STATS";
            TextFinder.Instance._BodyText.text = $"-   Current Code:  {Data.Instance._Code}\n" + "\n" +
                $"-   Total Rooms Joined:  {Data.Instance._TotalRooms}\n" + "\n" +
                $"-   Players:  {Data.Instance._Players}\n" + "\n" +
                $"-   Master:  {Data.Instance._MasterName}\n" + "\n" +
                $"-   Active Players: {Data.Instance._ActivePlayers}\n" + "\n" +
                $"-   Current Playtime: {Data.Instance._Playtime}\n" + "\n" +
                $"-   Ping: {Data.Instance._Ping}";
        }
    }
}
