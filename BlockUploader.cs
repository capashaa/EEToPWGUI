using PixelPilot.PixelGameClient.Messages.Send;
using PixelPilot.PixelGameClient.World.Blocks;
using PixelPilot.PixelGameClient.World.Constants;
using PixelPilot.PixelGameClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EELVL.Blocks;
using EELVL;
using System.Runtime.CompilerServices;
namespace EEtoPWGUI
{

    public class BlockUploader
    {
        public static void PlaceBlocks(PixelPilotClient client,string fileName)
        {
            //Change title name to level worldname
            bool changeName = false;
            //Convert EE blocks into PW blocks
            Dictionary<int, int> data = BlockConverter.EEtoPW();
            //Load EELVL from current directory
            Level lvl = Level.Open(fileName);
            if (client.IsConnected)
            {

                if (changeName) client.Send(new PlayerChatOutPacket($"/title {lvl.WorldName}"));
            }
            for (int x = 0; x < lvl.Width; x++)
            {
                for (int y = 0; y < lvl.Height; y++)
                {
                    if (data.ContainsKey(lvl[0, x, y].BlockID))
                    {
                        if (client.IsConnected)
                        {
                            client.Send(new BasicBlock(x, y, 1, data[lvl[0, x, y].BlockID]).AsPacketOut());
                            Thread.Sleep(10);
                        }
                    }
                    if (lvl[1, x, y].BlockID != 0 && data.ContainsKey(lvl[1, x, y].BlockID))
                    {
                        if (client.IsConnected)
                        {
                            client.Send(new BasicBlock(x, y, 0, data[lvl[1, x, y].BlockID]).AsPacketOut());
                            Thread.Sleep(10);
                        }

                    }
                    #region Door/gate
                    if (lvl[0, x, y].BlockID == 43)
                    {
                        if (client.IsConnected)
                        {
                            client.Send(new PixelPilot.PixelGameClient.World.Blocks.MorphableBlock(x, y, 1, (int)PixelBlock.CoinDoor, ((EELVL.Blocks.NumberBlock)lvl[0, x, y]).Number).AsPacketOut());
                            Thread.Sleep(10);
                        }
                    }
                    if (lvl[0, x, y].BlockID == 165)
                    {
                        if (client.IsConnected)
                        {
                            client.Send(new PixelPilot.PixelGameClient.World.Blocks.MorphableBlock(x, y, 1, (int)PixelBlock.CoinGate, ((EELVL.Blocks.NumberBlock)lvl[0, x, y]).Number).AsPacketOut());
                            Thread.Sleep(10);
                        }
                    }
                    if (lvl[0, x, y].BlockID == 214)
                    {
                        if (client.IsConnected)
                        {
                            client.Send(new PixelPilot.PixelGameClient.World.Blocks.MorphableBlock(x, y, 1, (int)PixelBlock.BlueCoinGate, ((EELVL.Blocks.NumberBlock)lvl[0, x, y]).Number).AsPacketOut());
                            Thread.Sleep(10);
                        }
                    }
                    if (lvl[0, x, y].BlockID == 213)
                    {
                        if (client.IsConnected)
                        {
                            client.Send(new PixelPilot.PixelGameClient.World.Blocks.MorphableBlock(x, y, 1, (int)PixelBlock.BlueCoinDoor, ((EELVL.Blocks.NumberBlock)lvl[0, x, y]).Number).AsPacketOut());
                            Thread.Sleep(10);
                        }
                    }
                    if (lvl[0, x, y].BlockID == 1011)
                    {
                        if (client.IsConnected)
                        {
                            client.Send(new PixelPilot.PixelGameClient.World.Blocks.MorphableBlock(x, y, 1, (int)PixelBlock.DeathDoor, ((EELVL.Blocks.NumberBlock)lvl[0, x, y]).Number).AsPacketOut());
                            Thread.Sleep(10);
                        }
                    }
                    if (lvl[0, x, y].BlockID == 1012)
                    {
                        if (client.IsConnected)
                        {
                            client.Send(new PixelPilot.PixelGameClient.World.Blocks.MorphableBlock(x, y, 1, (int)PixelBlock.DeathGate, ((EELVL.Blocks.NumberBlock)lvl[0, x, y]).Number).AsPacketOut());
                            Thread.Sleep(10);
                        }
                    }
                    #endregion

                    #region Portals
                    if (lvl[0, x, y].BlockID == 381)
                    {
                        if (client.IsConnected)
                        {
                            client.Send(new PixelPilot.PixelGameClient.World.Blocks.PortalBlock(x, y, 1, (int)PixelBlock.PortalInvisible, ((EELVL.Blocks.PortalBlock)lvl[0, x, y]).ID, ((EELVL.Blocks.PortalBlock)lvl[0, x, y]).Target, ((EELVL.Blocks.PortalBlock)lvl[0, x, y]).Rotation).AsPacketOut());
                            Thread.Sleep(10);
                        }
                    }
                    if (lvl[0, x, y].BlockID == 242)
                    {
                        if (client.IsConnected)
                        {
                            client.Send(new PixelPilot.PixelGameClient.World.Blocks.PortalBlock(x, y, 1, (int)PixelBlock.Portal, ((EELVL.Blocks.PortalBlock)lvl[0, x, y]).ID, ((EELVL.Blocks.PortalBlock)lvl[0, x, y]).Target, ((EELVL.Blocks.PortalBlock)lvl[0, x, y]).Rotation).AsPacketOut());
                            Thread.Sleep(10);
                        }
                    }
                    #endregion

                    #region Spikes
                    if (lvl[0, x, y].BlockID == 361 || lvl[0, x, y].BlockID == 1625 || lvl[0, x, y].BlockID == 1627 || lvl[0, x, y].BlockID == 1629 || lvl[0, x, y].BlockID == 1631 || lvl[0, x, y].BlockID == 1633 || lvl[0, x, y].BlockID == 1635)
                    {
                        if (client.IsConnected)
                        {
                            client.Send(new PixelPilot.PixelGameClient.World.Blocks.MorphableBlock(x, y, 1, (int)PixelBlock.Spikes, ((EELVL.Blocks.RotatableBlock)lvl[0, x, y]).Rotation).AsPacketOut());
                            Thread.Sleep(10);
                        }
                    }
                    #endregion

                    #region Global switches

                    if (lvl[0, x, y].BlockID == 467)
                    {
                        if (client.IsConnected)
                        {
                            client.Send(new PixelPilot.PixelGameClient.World.Blocks.MorphableBlock(x, y, 1, (int)PixelBlock.GlobalSwitch, ((EELVL.Blocks.NumberBlock)lvl[0, x, y]).Number).AsPacketOut());
                            Thread.Sleep(10);
                        }
                    }
                    if (lvl[0, x, y].BlockID == 1620)
                    {
                        if (client.IsConnected)
                        {
                            client.Send(new PixelPilot.PixelGameClient.World.Blocks.MorphableBlock(x, y, 1, (int)PixelBlock.GlobalSwitchResetter, ((EELVL.Blocks.NumberBlock)lvl[0, x, y]).Number).AsPacketOut());
                            Thread.Sleep(10);
                        }
                    }
                    if (lvl[0, x, y].BlockID == 1079)
                    {
                        if (client.IsConnected)
                        {
                            client.Send(new PixelPilot.PixelGameClient.World.Blocks.MorphableBlock(x, y, 1, (int)PixelBlock.GlobalSwitchDoor, ((EELVL.Blocks.NumberBlock)lvl[0, x, y]).Number).AsPacketOut());
                            Thread.Sleep(10);
                        }
                    }
                    if (lvl[0, x, y].BlockID == 1080)
                    {
                        if (client.IsConnected)
                        {
                            client.Send(new PixelPilot.PixelGameClient.World.Blocks.MorphableBlock(x, y, 1, (int)PixelBlock.GlobalSwitchGate, ((EELVL.Blocks.NumberBlock)lvl[0, x, y]).Number).AsPacketOut());
                            Thread.Sleep(10);
                        }
                    }
                    #endregion

                    #region Local switches

                    if (lvl[0, x, y].BlockID == 113)
                    {
                        if (client.IsConnected)
                        {
                            client.Send(new PixelPilot.PixelGameClient.World.Blocks.MorphableBlock(x, y, 1, (int)PixelBlock.LocalSwitch, ((EELVL.Blocks.NumberBlock)lvl[0, x, y]).Number).AsPacketOut());
                            Thread.Sleep(10);
                        }
                    }
                    if (lvl[0, x, y].BlockID == 1619)
                    {
                        if (client.IsConnected)
                        {
                            client.Send(new PixelPilot.PixelGameClient.World.Blocks.MorphableBlock(x, y, 1, (int)PixelBlock.LocalSwitchResetter, ((EELVL.Blocks.NumberBlock)lvl[0, x, y]).Number).AsPacketOut());
                            Thread.Sleep(10);
                        }
                    }
                    if (lvl[0, x, y].BlockID == 184)
                    {
                        if (client.IsConnected)
                        {
                            client.Send(new PixelPilot.PixelGameClient.World.Blocks.MorphableBlock(x, y, 1, (int)PixelBlock.LocalSwitchDoor, ((EELVL.Blocks.NumberBlock)lvl[0, x, y]).Number).AsPacketOut());
                            Thread.Sleep(10);
                        }
                    }
                    if (lvl[0, x, y].BlockID == 185)
                    {
                        if (client.IsConnected)
                        {
                            client.Send(new PixelPilot.PixelGameClient.World.Blocks.MorphableBlock(x, y, 1, (int)PixelBlock.LocalSwitchGate, ((EELVL.Blocks.NumberBlock)lvl[0, x, y]).Number).AsPacketOut());
                            Thread.Sleep(10);
                        }
                    }
                    #endregion

                }
            }
        }
    }
}

