using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7D2C.Classes
{
    class ServerManager
    {
        //GameManager.Instance.ExplosionServer(0, base.GetPosition(), World.worldToBlockPos(base.GetPosition()), base.transform.rotation, EntityClass.list[this.entityClass].explosionData, this.entityId, 0f, false, null);
        /*var clientInfo = SingletonMonoBehaviour<ConnectionManager>.Instance.Clients.ForEntityId(entityPlayer.entityId);
        var addScorePacket = new NetPackageEntityAddScoreServer();
        addScorePacket.Setup(entityPlayer.entityId, 1000, 1000, 0, 1);
        addScorePacket.ProcessPackage(GameManager.Instance.World, GameManager.Instance);
        clientInfo.SendPackage(addScorePacket);

        Debug.Log(clientInfo.ip);*/

        //NetPackageManager.GetPackage<NetPackageEntityAddScoreServer>().
        //SingletonMonoBehaviour<ConnectionManager>.Instance.SendPackage(NetPackageManager.GetPackage<NetPackagePartyData>().Setup(invitedBy.Party, invitedEntity.entityId, NetPackagePartyData.PartyActions.AcceptInvite, false), false, -1, -1, -1, -1);
    }
}
