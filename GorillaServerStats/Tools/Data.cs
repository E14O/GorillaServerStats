using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

namespace GorillaServerStats.Tools
{
    public class Data : MonoBehaviourPunCallbacks
    {
        public static Data Instance;

        public int _ActivePlayers = 0, _TotalRooms = 0;
        public string _Code = "N/A", _MasterName = "N/A", _Playtime = "00:00:00", _Ping = "N/A", _Players = "N/A";

        private float _Duration;

        void Awake() => Instance = this;

        public override void OnJoinedRoom()
        {
            _ActivePlayers = PhotonNetwork.CountOfPlayers;

            _Code = PhotonNetwork.CurrentRoom.Name;
            _MasterName = PhotonNetwork.MasterClient.NickName;
            _TotalRooms += 1;
            _Players = PhotonNetwork.CurrentRoom.PlayerCount.ToString();
        }

        public override void OnLeftRoom()
        {
            _ActivePlayers = PhotonNetwork.CountOfPlayers;

            _Code = "N/A";
            _MasterName = "N/A";
            _Players = "N/A";
        }

        public override void OnPlayerEnteredRoom(Player newPlayer) => _Players = PhotonNetwork.CurrentRoom.PlayerCount.ToString();
        public override void OnPlayerLeftRoom(Player otherPlayer) => _Players = PhotonNetwork.CurrentRoom.PlayerCount.ToString();

        public void Update()
        {
            _Ping = $"{PhotonNetwork.GetPing()}ms";

            _Duration += Time.deltaTime;

            int _Hours = (int)(_Duration / 3600f);
            int _Min = (int)(_Duration % 3600f / 60f);
            int _Sec = (int)(_Duration % 60f);

            _Playtime = $"{_Hours:00}:{_Min:00}:{_Sec:00}";
        }
    }
}
