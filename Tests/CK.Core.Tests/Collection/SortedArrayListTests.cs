﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using CK.Core;

namespace Core.Collection
{
    [TestFixture]
    public class SortedArrayListTests
    {
        [Test]
        public void Simple()
        {
            var a = new SortedArrayList<int>();
            a.AddRange( new[] { 12, -34, 7, 545, 12 } );
            Assert.That( a.Count, Is.EqualTo( 4 ) );
            Assert.That( a, Is.Ordered );

            Assert.That( a.Contains( 14 ), Is.False );
            Assert.That( a.IndexOf( 12 ), Is.EqualTo( 2 ) );

            object o = 21;
            Assert.That( a.Contains( o ), Is.False );
            Assert.That( a.IndexOf( o ), Is.LessThan( 0 ) );

            o = 12;
            Assert.That( a.Contains( o ), Is.True );
            Assert.That( a.IndexOf( o ), Is.EqualTo( 2 ) );
        }

        [Test]
        public void Covariance()
        {
            var a = new SortedArrayList<Mammals>( ( a1, a2 ) => a1.Name.CompareTo( a2.Name ) );
            a.Add( new Mammals( "B", 12 ) );
            a.Add( new Canidae( "A", 12, true ) );

            IReadOnlyList<Animals> baseObjects = a;
            for( int i = 0; i < baseObjects.Count; ++i ) Console.Write( baseObjects[i].Name );

            IWritableCollection<Canidae> dogs = a;
            dogs.Add( new Canidae( "C", 8, false ) );
        }

        class TestMammals : SortedArrayList<Mammals>
        {
            public TestMammals( Comparison<Mammals> m )
                : base( m )
            {
            }

            public Mammals[] Tab { get { return Store; } }
        }

        [Test]
        public void CheckPos()
        {
            var a = new TestMammals( ( a1, a2 ) => a1.Name.CompareTo( a2.Name ) );
            a.Add( new Mammals( "B" ) );
            a.Add( new Mammals( "A" ) );
            a.Add( new Mammals( "D" ) );
            a.Add( new Mammals( "F" ) );
            a.Add( new Mammals( "C" ) );
            a.Add( new Mammals( "E" ) );
            Assert.That( String.Join( "", a.Select( m => m.Name ) ), Is.EqualTo( "ABCDEF" ) );

            for( int i = 0; i < a.Count; ++i )
            {
                Assert.That( a.CheckPosition( i ), Is.EqualTo( i ), "Nothing changed." );
            }
            CheckList( a, "ABCDEF" );

            a[0].Name = "Z";
            CheckList( a, "ZBCDEF" );
            Assert.That( a.CheckPosition( 0 ), Is.EqualTo( 5 ) );
            CheckList( a, "BCDEFZ" );
            a[5].Name = "Z+";
            CheckList( a, "BCDEFZ+" );
            Assert.That( a.CheckPosition( 5 ), Is.EqualTo( 5 ) );
            CheckList( a, "BCDEFZ+" );
            a[5].Name = "A";
            Assert.That( a.CheckPosition( 5 ), Is.EqualTo( 0 ) );
            CheckList( a, "ABCDEF" );

            a[1].Name = "A";
            Assert.That( a.CheckPosition( 1 ), Is.LessThan( 0 ) );
            CheckList( a, "AACDEF" );

            a[1].Name = "B";
            Assert.That( a.CheckPosition( 1 ), Is.EqualTo( 1 ) );
            CheckList( a, "ABCDEF" );

            a[1].Name = "C";
            Assert.That( a.CheckPosition( 1 ), Is.LessThan( 0 ) );
            CheckList( a, "ACCDEF" );

            a[1].Name = "Z";
            Assert.That( a.CheckPosition( 1 ), Is.EqualTo( 5 ) );
            CheckList( a, "ACDEFZ" );

            a[5].Name = "D+";
            Assert.That( a.CheckPosition( 5 ), Is.EqualTo( 3 ) );
            CheckList( a, "ACDD+EF" );

            a[3].Name = "D";
            Assert.That( a.CheckPosition( 3 ), Is.LessThan( 0 ) );
            CheckList( a, "ACDDEF" );
            
            a[3].Name = "B";
            Assert.That( a.CheckPosition( 3 ), Is.EqualTo( 1 ) );
            CheckList( a, "ABCDEF" );
        }

        private static void CheckList( TestMammals a, string p )
        {
            HashSet<Mammals> dup = new HashSet<Mammals>();
            int i = 0;
            while( i < a.Count )
            {
                Assert.That( a[i], Is.Not.Null );
                Assert.That( dup.Add( a[i] ), Is.True );
                ++i;
            }
            while( i < a.Tab.Length )
            {
                Assert.That( a.Tab[i], Is.Null );
                ++i;
            }
            Assert.That( String.Join( "", a.Select( m => m.Name ) ), Is.EqualTo( p ) );
        }


        class TestInt : SortedArrayList<int>
        {
            public TestInt()
            {
            }

            public int[] Tab { get { return Store; } }

            public void CheckList()
            {
                Assert.That( this.IsSortedStrict() );
                int i = Count;
                while( i < Tab.Length )
                {
                    Assert.That( Tab[i], Is.EqualTo( default(int) ) );
                    ++i;
                }
            }
        }

        private static void CheckList( TestInt a, params int[] p )
        {
            a.CheckList();
            Assert.That( a.SequenceEqual( p ) );
        }

        [Test]
        public void AddRemove()
        {
            var a = new TestInt();
            a.CheckList();
            Assert.Throws<IndexOutOfRangeException>( () => a.RemoveAt( -1 ) );
            Assert.Throws<IndexOutOfRangeException>( () => a.RemoveAt( 0 ) );
            Assert.Throws<IndexOutOfRangeException>( () => a.RemoveAt( 1 ) );

            a.Add( 204 );
            a.CheckList();
            Assert.Throws<IndexOutOfRangeException>( () => a.RemoveAt( -1 ) );
            Assert.Throws<IndexOutOfRangeException>( () => a.RemoveAt( 1 ) );

            a.RemoveAt( 0 );
            Assert.That( a.Count, Is.EqualTo( 0 ) );
            a.CheckList();

            a.Add( 206 );
            a.Add( 205 );
            a.Add( 204 );
            CheckList( a, 204, 205, 206 );

            a.RemoveAt( 1 );
            CheckList( a, 204, 206 );
            Assert.Throws<IndexOutOfRangeException>( () => a.RemoveAt( 2 ) );
            a.RemoveAt( 1 );
            CheckList( a, 204 );
            a.RemoveAt( 0 );
            CheckList( a );

            a.Add( 206 );
            a.Add( 205 );
            a.Add( 204 );
            a.Add( 207 );
            a.Add( 208 );
            CheckList( a, 204, 205, 206, 207, 208 );
            Assert.Throws<IndexOutOfRangeException>( () => a.RemoveAt( 5 ) );
            a.RemoveAt( 0 );
            CheckList( a, 205, 206, 207, 208 );
            a.RemoveAt( 3 );
            CheckList( a, 205, 206, 207 );
            a.RemoveAt( 1 );
            CheckList( a, 205, 207 );
            a.RemoveAt( 1 );
            CheckList( a, 205 );
            a.RemoveAt( 0 );
            CheckList( a );

        }


    }
}
