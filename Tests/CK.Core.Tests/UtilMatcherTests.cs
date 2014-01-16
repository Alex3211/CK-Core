﻿#region LGPL License
/*----------------------------------------------------------------------------
* This file (Tests\CK.Core.Tests\UtilInterlockedTests.cs) is part of CiviKey. 
*  
* CiviKey is free software: you can redistribute it and/or modify 
* it under the terms of the GNU Lesser General Public License as published 
* by the Free Software Foundation, either version 3 of the License, or 
* (at your option) any later version. 
*  
* CiviKey is distributed in the hope that it will be useful, 
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the 
* GNU Lesser General Public License for more details. 
* You should have received a copy of the GNU Lesser General Public License 
* along with CiviKey.  If not, see <http://www.gnu.org/licenses/>. 
*  
* Copyright © 2007-2012, 
*     Invenietis <http://www.invenietis.com>,
*     In’Tech INFO <http://www.intechinfo.fr>,
* All rights reserved. 
*-----------------------------------------------------------------------------*/
#endregion

using System;
using NUnit.Framework;

namespace CK.Core.Tests
{
    [TestFixture]
    public class UtilMatcherTests
    {
        [Test]
        public void BasicMatch()
        {
            string s = " AB  \t\r C";
            int idx = 0;
            Assert.That( Util.Matcher.Match( s, ref idx, "A" ), Is.False );
            Assert.That( idx, Is.EqualTo( 0 ) );
            Assert.That( Util.Matcher.MatchWhiteSpaces( s, ref idx ), Is.True );
            Assert.That( idx, Is.EqualTo( 1 ) );
            Assert.That( Util.Matcher.Match( s, ref idx, "A" ), Is.True );
            Assert.That( Util.Matcher.Match( s, ref idx, "B" ), Is.True );
            Assert.That( idx, Is.EqualTo( 3 ) );
            Assert.That( Util.Matcher.MatchWhiteSpaces( s, ref idx ), Is.True );
            Assert.That( idx, Is.EqualTo( 8 ) );
            Assert.That( Util.Matcher.Match( s, ref idx, "c" ), Is.True );
            Assert.That( idx, Is.EqualTo( s.Length ) );


            Assert.DoesNotThrow( () => Util.Matcher.Match( s, ref idx, "c" ) );
            Assert.DoesNotThrow( () => Util.Matcher.MatchWhiteSpaces( s, ref idx ) );
            Assert.That( Util.Matcher.Match( s, ref idx, "A" ), Is.False );
            Assert.That( Util.Matcher.MatchWhiteSpaces( s, ref idx ), Is.False );
        }
        
    }
}
