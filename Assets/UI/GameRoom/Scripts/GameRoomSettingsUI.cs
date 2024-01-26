using Mirror;

public class GameRoomSettingsUI : SettingsUI
{
    public void ExitGameRoom()
    {
        var manager = AmongUsRoomManager.singleton;
        if (manager.isNetworkActive)
        {
            if (manager.mode == Mirror.NetworkManagerMode.Host)
            {
                manager.StopHost();
            }
            else if (manager.mode == Mirror.NetworkManagerMode.ClientOnly)
            {
                manager.StopClient();
            }
        }
    }
}
