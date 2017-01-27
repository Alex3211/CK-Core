using FluentAssertions;
using System;
using Xunit;

namespace CK.Core.Tests
{

    public class UtilInterlockedTests
    {
        [Fact]
        public void InterlockedAdd_atomically_adds_an_item_to_an_array()
        {
            int[] a = null;
            Util.InterlockedAdd(ref a, 1);
            a.Should().NotBeNull();
            a.ShouldBeEquivalentTo(new[] { 1 }, o => o.WithStrictOrdering());
            Util.InterlockedAdd(ref a, 2);
            a.ShouldBeEquivalentTo(new[] { 1, 2 }, o => o.WithStrictOrdering());
            Util.InterlockedAdd(ref a, 3);
            a.ShouldBeEquivalentTo(new[] { 1, 2, 3 }, o => o.WithStrictOrdering());
        }

        [Fact]
        public void InterlockedAdd_can_add_an_item_in_front_of_an_array()
        {
            int[] a = null;
            Util.InterlockedAdd(ref a, 1, true);
            a.Should().NotBeNull();
            a.ShouldBeEquivalentTo(new[] { 1 }, o => o.WithStrictOrdering());
            Util.InterlockedAdd(ref a, 2, true);
            a.ShouldBeEquivalentTo(new[] { 2, 1 }, o => o.WithStrictOrdering());
            Util.InterlockedAdd(ref a, 3, true);
            a.ShouldBeEquivalentTo(new[] { 3, 2, 1 }, o => o.WithStrictOrdering());
        }

        [Fact]
        public void InterlockedAddUnique_tests_the_occurrence_of_the_item()
        {
            {
                // Prepend
                int[] a = null;
                Util.InterlockedAddUnique(ref a, 1, true);
                a.ShouldBeEquivalentTo(new[] { 1 }, o => o.WithStrictOrdering());
                var theA = a;
                Util.InterlockedAddUnique(ref a, 1, true);
                a.Should().BeSameAs(theA);
                Util.InterlockedAddUnique(ref a, 2, true);
                a.ShouldBeEquivalentTo(new[] { 2, 1 }, o => o.WithStrictOrdering());
                theA = a;
                Util.InterlockedAddUnique(ref a, 2, true);
                a.Should().BeSameAs(theA);
            }
            {
                // Append
                int[] a = null;
                Util.InterlockedAddUnique(ref a, 1);
                a.ShouldBeEquivalentTo(new[] { 1 }, o => o.WithStrictOrdering());
                var theA = a;
                Util.InterlockedAddUnique(ref a, 1);
                a.Should().BeSameAs(theA);
                Util.InterlockedAddUnique(ref a, 2);
                a.ShouldBeEquivalentTo(new[] { 1, 2 }, o => o.WithStrictOrdering());
                theA = a;
                Util.InterlockedAddUnique(ref a, 2);
                a.Should().BeSameAs(theA);
            }
        }

        [Fact]
        public void InterlockedRemove_an_item_from_an_array()
        {
            int[] a = new[] { 1, 2, 3, 4, 5, 6, 7 };
            Util.InterlockedRemove(ref a, 1);
            a.ShouldBeEquivalentTo(new[] { 2, 3, 4, 5, 6, 7 }, o => o.WithStrictOrdering());
            Util.InterlockedRemove(ref a, 4);
            a.ShouldBeEquivalentTo(new[] { 2, 3, 5, 6, 7 }, o => o.WithStrictOrdering());
            Util.InterlockedRemove(ref a, 3712);
            a.ShouldBeEquivalentTo(new[] { 2, 3, 5, 6, 7 }, o => o.WithStrictOrdering());
            Util.InterlockedRemove(ref a, 7);
            a.ShouldBeEquivalentTo(new[] { 2, 3, 5, 6 }, o => o.WithStrictOrdering());
            Util.InterlockedRemove(ref a, 3);
            a.ShouldBeEquivalentTo(new[] { 2, 5, 6 }, o => o.WithStrictOrdering());
            Util.InterlockedRemove(ref a, 5);
            a.ShouldBeEquivalentTo(new[] { 2, 6 }, o => o.WithStrictOrdering());
            Util.InterlockedRemove(ref a, 3712);
            a.ShouldBeEquivalentTo(new[] { 2, 6 }, o => o.WithStrictOrdering());
            Util.InterlockedRemove(ref a, 6);
            a.ShouldBeEquivalentTo(new[] { 2 }, o => o.WithStrictOrdering());
            Util.InterlockedRemove(ref a, 2);
            a.ShouldBeEquivalentTo(Util.Array.Empty<int>(), o => o.WithStrictOrdering());

            var aEmpty = a;
            Util.InterlockedRemove(ref a, 2);
            a.Should().BeSameAs(aEmpty);

            Util.InterlockedRemove(ref a, 3712);
            a.Should().BeSameAs(aEmpty);

            a = null;
            Util.InterlockedRemove(ref a, 3712);
            a.Should().BeNull();

        }

        [Fact]
        public void InterlockedRemoveAll_items_that_match_a_condition()
        {
            int[] a = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Util.InterlockedRemoveAll(ref a, i => i % 2 == 0);
            a.ShouldBeEquivalentTo(new[] { 1, 3, 5, 7, 9 }, o => o.WithStrictOrdering());
            Util.InterlockedRemoveAll(ref a, i => i % 2 != 0);
            a.ShouldBeEquivalentTo(Util.Array.Empty<int>(), o => o.WithStrictOrdering());

            a = null;
            Util.InterlockedRemoveAll(ref a, i => i % 2 != 0);
            a.Should().BeNull();
        }

        [Fact]
        public void InterlockedRemove_removes_the_first_item_that_matches_a_condition()
        {
            int[] a = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Util.InterlockedRemove(ref a, i => i % 2 == 0);
            a.ShouldBeEquivalentTo(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, o => o.WithStrictOrdering());
            Util.InterlockedRemove(ref a, i => i > 7);
            a.ShouldBeEquivalentTo(new[] { 1, 2, 3, 4, 5, 6, 7, 9 }, o => o.WithStrictOrdering());
        }

        [Fact]
        public void InterlockedAdd_item_under_condition()
        {
            int[] a = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var theA = a;
            Util.InterlockedAdd(ref a, i => i == 3, () => 3);
            a.Should().BeSameAs(theA);

            Util.InterlockedAdd(ref a, i => i == 10, () => 10);
            a.ShouldBeEquivalentTo(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, o => o.WithStrictOrdering());

            Util.InterlockedAdd(ref a, i => i == -1, () => -1, true);
            a.ShouldBeEquivalentTo(new[] { -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, o => o.WithStrictOrdering());

            Should.Throw<InvalidOperationException>(() => Util.InterlockedAdd(ref a, i => i == 11, () => 10));

            a = null;
            Util.InterlockedAdd(ref a, i => i == 3, () => 3);
            a.ShouldBeEquivalentTo(new[] { 3 }, o => o.WithStrictOrdering());
            Util.InterlockedAdd(ref a, i => i == 4, () => 4);
            a.ShouldBeEquivalentTo(new[] { 3, 4 }, o => o.WithStrictOrdering());

            a = new int[0];
            Util.InterlockedAdd(ref a, i => i == 3, () => 3);
            a.ShouldBeEquivalentTo(new[] { 3 }, o => o.WithStrictOrdering());
            Util.InterlockedAdd(ref a, i => i == 4, () => 4);
            a.ShouldBeEquivalentTo(new[] { 3, 4 }, o => o.WithStrictOrdering());
        }
    }
}
