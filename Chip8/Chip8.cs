using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chip8
{
    class Chip8
    {
        #region Registers
        // General Purpose Registers (8 Bit)

        /// <summary>
        /// General Purpose Register 0 (8 Bit)
        /// </summary>
        public byte V0 { get; set; }
        /// <summary>
        /// General Purpose Register 1 (8 Bit)
        /// </summary>
        public byte V1 { get; set; }
        /// <summary>
        /// General Purpose Register 2 (8 Bit)
        /// </summary>
        public byte V2 { get; set; }
        /// <summary>
        /// General Purpose Register 3 (8 Bit)
        /// </summary>
        public byte V3 { get; set; }
        /// <summary>
        /// General Purpose Register 4 (8 Bit)
        /// </summary>
        public byte V4 { get; set; }
        /// <summary>
        /// General Purpose Register 5 (8 Bit)
        /// </summary>
        public byte V5 { get; set; }
        /// <summary>
        /// General Purpose Register 6 (8 Bit)
        /// </summary>
        public byte V6 { get; set; }
        /// <summary>
        /// General Purpose Register 7 (8 Bit)
        /// </summary>
        public byte V7 { get; set; }
        /// <summary>
        /// General Purpose Register 8 (8 Bit)
        /// </summary>
        public byte V8 { get; set; }
        /// <summary>
        /// General Purpose Register 9 (8 Bit)
        /// </summary>
        public byte V9 { get; set; }
        /// <summary>
        /// General Purpose Register 10 (8 Bit)
        /// </summary>
        public byte VA { get; set; }
        /// <summary>
        /// General Purpose Register 11 (8 Bit)
        /// </summary>
        public byte VB { get; set; }
        /// <summary>
        /// General Purpose Register 12 (8 Bit)
        /// </summary>
        public byte VC { get; set; }
        /// <summary>
        /// General Purpose Register 13 (8 Bit)
        /// </summary>
        public byte VD { get; set; }
        /// <summary>
        /// General Purpose Register 14 (8 Bit)
        /// </summary>
        public byte VE { get; set; }
        /// <summary>
        /// General Purpose Register 15 (8 Bit).
        /// Should not be used by programs as is used by some instructions
        /// </summary>
        public byte VF { get; set; }
        /// <summary>
        /// 16 Bit register
        /// </summary>
        public ushort VI { get; set; } // 16 Bit register

        /// <summary>
        /// Program Counter Register (16 Bit)
        /// </summary>
        public ushort PC { get; private set; }
        /// <summary>
        /// Stack Pointer Register (8 Bit)
        /// </summary>
        public byte SP { get; private set; }
        
        /// <summary>
        /// Stack (16 x 16 Bytes)
        /// </summary>
        public ushort[] Stack { get; set; } //TODO: Stack Class
        #endregion

        /// <summary>
        /// 4K of Memory
        /// </summary>
        public byte[] RAM { get; set; }

        public Chip8()
        {
            Stack = new ushort[16];
            RAM = new byte[0x1000];
        }
    }
}
