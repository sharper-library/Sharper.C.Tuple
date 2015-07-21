using System;

namespace Sharper.C
{
    public static class TupleOps
    {
        public static Tuple<A, B> Pair<A, B>(A a, B b) => Tuple.Create(a, b);

        public static Tuple<A, B, C>
            Triple<A, B, C>(A a, B b, C c) => Tuple.Create(a, b, c);

        public static C Call<A, B, C>(this Tuple<A, B> t, Func<A, B, C> f)
            => f(t.Item1, t.Item2);

        public static D
            Call<A, B, C, D>(this Tuple<A, B, C> t, Func<A, B, C, D> f)
            => f(t.Item1, t.Item2, t.Item3);

        public static Tuple<C, B>
            MapFst<A, B, C>(this Tuple<A, B> t, Func<A, C> f)
            => Pair(f(t.Item1), t.Item2);

        public static Tuple<D, B, C>
            MapFst<A, B, C, D>(this Tuple<A, B, C> t, Func<A, D> f)
            => Triple(f(t.Item1), t.Item2, t.Item3);

        public static Tuple<A, C>
            MapSnd<A, B, C>(this Tuple<A, B> t, Func<B, C> f)
            => Pair(t.Item1, f(t.Item2));

        public static Tuple<A, D, C>
            MapSnd<A, B, C, D>(this Tuple<A, B, C> t, Func<B, D> f)
            => Triple(t.Item1, f(t.Item2), t.Item3);

        public static Tuple<A, B, D>
            MapTrd<A, B, C, D>(this Tuple<A, B, C> t, Func<C, D> f)
            => Triple(t.Item1, t.Item2, f(t.Item3));
    }
}
