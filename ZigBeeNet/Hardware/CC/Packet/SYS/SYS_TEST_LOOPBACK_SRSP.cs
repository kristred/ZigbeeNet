﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ZigBeeNet.Hardware.CC.Packet.SYS
{
    public class SYS_TEST_LOOPBACK_SRSP : ZToolPacket
    {
        public byte[] TestData;

        public SYS_TEST_LOOPBACK_SRSP()
        {

        }

        public SYS_TEST_LOOPBACK_SRSP(byte[] framedata)
        {
            this.TestData = new byte[framedata.Length];
            this.TestData = framedata;
            BuildPacket(new DoubleByte(ZToolCMD.SYS_TEST_LOOPBACK_SRSP), framedata);
        }
    }
}