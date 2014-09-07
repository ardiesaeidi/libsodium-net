﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    /// <summary>
    /// Tests for the Utitlities class
    /// </summary>
    [TestFixture]
    public class UtilitiesTest
    {

        /// <summary>
        /// A simple test for validating the hex method.
        /// </summary>
        [Test]
        public void HexToBinaryTest()
        {
            const string ACTUAL = "77076d0a7318a57d3c16c17251b26645df4c2f87ebc0992ab177fba51db92c2a";
            const string ACTUAL_UPPER = "77076D0A7318A57D3C16C17251B26645DF4C2F87EBC0992AB177FBA51DB92C2A";
            var expected = new byte[32] {
				0x77,0x07,0x6d,0x0a,0x73,0x18,0xa5,0x7d,
				0x3c,0x16,0xc1,0x72,0x51,0xb2,0x66,0x45,
				0xdf,0x4c,0x2f,0x87,0xeb,0xc0,0x99,0x2a,
				0xb1,0x77,0xfb,0xa5,0x1d,0xb9,0x2c,0x2a
            };

            byte[] binSodiumLower = Sodium.Utilities.HexToBinary(ACTUAL);
            byte[] binSodiumUpper = Sodium.Utilities.HexToBinary(ACTUAL_UPPER);
            Assert.AreEqual(expected, binSodiumLower);
            Assert.AreEqual(expected, binSodiumUpper);
        }

        /// <summary>
        /// Test the hex decoding with some colons.
        /// </summary>
        [Test]
        public void HexToBinaryColonTest()
        {
            const string ACTUAL = "77:07:6d:0a:73:18:a5:7d:3c:16:c1:72:51:b2:66:45:df:4c:2f:87:eb:c0:99:2a:b1:77:fb:a5:1d:b9:2c:2a";
            const string ACTUAL_UPPER = "77:07:6D:0A:73:18:A5:7D:3C:16:C1:72:51:B2:66:45:DF:4C:2F:87:EB:C0:99:2A:B1:77:FB:A5:1D:B9:2C:2A";
            var expected = new byte[32] {
				0x77,0x07,0x6d,0x0a,0x73,0x18,0xa5,0x7d,
				0x3c,0x16,0xc1,0x72,0x51,0xb2,0x66,0x45,
				0xdf,0x4c,0x2f,0x87,0xeb,0xc0,0x99,0x2a,
				0xb1,0x77,0xfb,0xa5,0x1d,0xb9,0x2c,0x2a
            };

            byte[] binSodiumLower = Sodium.Utilities.HexToBinary(ACTUAL);
            byte[] binSodiumUpper = Sodium.Utilities.HexToBinary(ACTUAL_UPPER);
            Assert.AreEqual(expected, binSodiumLower);
            Assert.AreEqual(expected, binSodiumUpper);
        }

        /// <summary>
        /// Test the hex decoding with some hyphens.
        /// </summary>
        [Test]
        public void HexToBinaryHyphenTest()
        {
            const string ACTUAL = "77-07-6d-0a-73-18-a5-7d-3c-16-c1-72-51-b2-66-45-df-4c-2f-87-eb-c0-99-2a-b1-77-fb-a5-1d-b9-2c-2a";
            const string ACTUAL_UPPER = "77-07-6D-0A-73-18-A5-7D-3C-16-C1-72-51-B2-66-45-DF-4C-2F-87-EB-C0-99-2A-B1-77-FB-A5-1D-B9-2C-2A";
            var expected = new byte[32] {
				0x77,0x07,0x6d,0x0a,0x73,0x18,0xa5,0x7d,
				0x3c,0x16,0xc1,0x72,0x51,0xb2,0x66,0x45,
				0xdf,0x4c,0x2f,0x87,0xeb,0xc0,0x99,0x2a,
				0xb1,0x77,0xfb,0xa5,0x1d,0xb9,0x2c,0x2a
            };

            byte[] binSodiumLower = Sodium.Utilities.HexToBinary(ACTUAL);
            byte[] binSodiumUpper = Sodium.Utilities.HexToBinary(ACTUAL_UPPER);
            Assert.AreEqual(expected, binSodiumLower);
            Assert.AreEqual(expected, binSodiumUpper);
        }

        /// <summary>
        /// Test the hex decoding with some spaces.
        /// </summary>
        [Test]
        public void HexToBinarySpaceTest()
        {
            const string ACTUAL = "77 07 6d 0a 73 18 a5 7d 3c 16 c1 72 51 b2 66 45 df 4c 2f 87 eb c0 99 2a b1 77 fb a5 1d b9 2c 2a";
            const string ACTUAL_UPPER = "77 07 6D 0A 73 18 A5 7D 3C 16 C1 72 51 B2 66 45 DF 4C 2F 87 EB C0 99 2A B1 77 FB A5 1D B9 2C 2A";
            var expected = new byte[32] {
				0x77,0x07,0x6d,0x0a,0x73,0x18,0xa5,0x7d,
				0x3c,0x16,0xc1,0x72,0x51,0xb2,0x66,0x45,
				0xdf,0x4c,0x2f,0x87,0xeb,0xc0,0x99,0x2a,
				0xb1,0x77,0xfb,0xa5,0x1d,0xb9,0x2c,0x2a
            };

            byte[] binSodiumLower = Sodium.Utilities.HexToBinary(ACTUAL);
            byte[] binSodiumUpper = Sodium.Utilities.HexToBinary(ACTUAL_UPPER);
            Assert.AreEqual(expected, binSodiumLower);
            Assert.AreEqual(expected, binSodiumUpper);
        }

        /// <summary>
        /// A simple test for validating the two hex methods.
        /// </summary>
        [Test]
        public void BinaryToHexTest()
        {
            const string EXPECTED = "77076d0a7318a57d3c16c17251b26645df4c2f87ebc0992ab177fba51db92c2a";
            const string EXPECTED_UPPER = "77076D0A7318A57D3C16C17251B26645DF4C2F87EBC0992AB177FBA51DB92C2A";
            var aliceSk = new byte[32] {
				0x77,0x07,0x6d,0x0a,0x73,0x18,0xa5,0x7d,
				0x3c,0x16,0xc1,0x72,0x51,0xb2,0x66,0x45,
				0xdf,0x4c,0x2f,0x87,0xeb,0xc0,0x99,0x2a,
				0xb1,0x77,0xfb,0xa5,0x1d,0xb9,0x2c,0x2a
            };

            string hexSharpLower = Sodium.Utilities.BinaryToHex(aliceSk, Sodium.HexFormat.None, Sodium.HexCase.Lower);
            string hexSharpUpper = Sodium.Utilities.BinaryToHex(aliceSk, Sodium.HexFormat.None, Sodium.HexCase.Upper);
            string hexSodium = Sodium.Utilities.BinaryToHex(aliceSk);

            Assert.AreEqual(EXPECTED, hexSharpLower);
            Assert.AreEqual(EXPECTED_UPPER, hexSharpUpper);
            Assert.AreEqual(EXPECTED, hexSodium);
        }

        /// <summary>
        /// Test the hex encoding with some colons.
        /// </summary>
        [Test]
        public void BinaryToHexColonTest()
        {
            const string EXPECTED = "77:07:6d:0a:73:18:a5:7d:3c:16:c1:72:51:b2:66:45:df:4c:2f:87:eb:c0:99:2a:b1:77:fb:a5:1d:b9:2c:2a";
            const string EXPECTED_UPPER = "77:07:6D:0A:73:18:A5:7D:3C:16:C1:72:51:B2:66:45:DF:4C:2F:87:EB:C0:99:2A:B1:77:FB:A5:1D:B9:2C:2A";
            var aliceSk = new byte[32] {
				0x77,0x07,0x6d,0x0a,0x73,0x18,0xa5,0x7d,
				0x3c,0x16,0xc1,0x72,0x51,0xb2,0x66,0x45,
				0xdf,0x4c,0x2f,0x87,0xeb,0xc0,0x99,0x2a,
				0xb1,0x77,0xfb,0xa5,0x1d,0xb9,0x2c,0x2a
            };

            string hexSharpLower = Sodium.Utilities.BinaryToHex(aliceSk, Sodium.HexFormat.Colon, Sodium.HexCase.Lower);
            string hexSharpUpper = Sodium.Utilities.BinaryToHex(aliceSk, Sodium.HexFormat.Colon, Sodium.HexCase.Upper);

            Assert.AreEqual(EXPECTED, hexSharpLower);
            Assert.AreEqual(EXPECTED_UPPER, hexSharpUpper);
        }

        /// <summary>
        /// Test the hex encoding with some hyphens.
        /// </summary>
        [Test]
        public void BinaryToHexHyphenTest()
        {
            const string EXPECTED = "77-07-6d-0a-73-18-a5-7d-3c-16-c1-72-51-b2-66-45-df-4c-2f-87-eb-c0-99-2a-b1-77-fb-a5-1d-b9-2c-2a";
            const string EXPECTED_UPPER = "77-07-6D-0A-73-18-A5-7D-3C-16-C1-72-51-B2-66-45-DF-4C-2F-87-EB-C0-99-2A-B1-77-FB-A5-1D-B9-2C-2A";
            var aliceSk = new byte[32] {
				0x77,0x07,0x6d,0x0a,0x73,0x18,0xa5,0x7d,
				0x3c,0x16,0xc1,0x72,0x51,0xb2,0x66,0x45,
				0xdf,0x4c,0x2f,0x87,0xeb,0xc0,0x99,0x2a,
				0xb1,0x77,0xfb,0xa5,0x1d,0xb9,0x2c,0x2a
            };

            string hexSharpLower = Sodium.Utilities.BinaryToHex(aliceSk, Sodium.HexFormat.Hyphen, Sodium.HexCase.Lower);
            string hexSharpUpper = Sodium.Utilities.BinaryToHex(aliceSk, Sodium.HexFormat.Hyphen, Sodium.HexCase.Upper);

            Assert.AreEqual(EXPECTED, hexSharpLower);
            Assert.AreEqual(EXPECTED_UPPER, hexSharpUpper);
        }

        /// <summary>
        /// Test the hex encoding with some spaces.
        /// </summary>
        [Test]
        public void BinaryToHexSpaceTest()
        {
            const string EXPECTED = "77 07 6d 0a 73 18 a5 7d 3c 16 c1 72 51 b2 66 45 df 4c 2f 87 eb c0 99 2a b1 77 fb a5 1d b9 2c 2a";
            const string EXPECTED_UPPER = "77 07 6D 0A 73 18 A5 7D 3C 16 C1 72 51 B2 66 45 DF 4C 2F 87 EB C0 99 2A B1 77 FB A5 1D B9 2C 2A";
            var aliceSk = new byte[32] {
				0x77,0x07,0x6d,0x0a,0x73,0x18,0xa5,0x7d,
				0x3c,0x16,0xc1,0x72,0x51,0xb2,0x66,0x45,
				0xdf,0x4c,0x2f,0x87,0xeb,0xc0,0x99,0x2a,
				0xb1,0x77,0xfb,0xa5,0x1d,0xb9,0x2c,0x2a
            };

            string hexSharpLower = Sodium.Utilities.BinaryToHex(aliceSk, Sodium.HexFormat.Space, Sodium.HexCase.Lower);
            string hexSharpUpper = Sodium.Utilities.BinaryToHex(aliceSk, Sodium.HexFormat.Space, Sodium.HexCase.Upper);

            Assert.AreEqual(EXPECTED, hexSharpLower);
            Assert.AreEqual(EXPECTED_UPPER, hexSharpUpper);
        }
    }
}
