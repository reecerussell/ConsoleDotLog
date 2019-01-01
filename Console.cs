using System.Runtime.CompilerServices;

namespace ConsoleDotLog
{
    public class console
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void log()
        {
            System.Console.WriteLine();
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void log(bool value)
        {
            System.Console.WriteLine(value);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void log(char value)
        {
            System.Console.WriteLine(value);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void log(char[] buffer)
        {
            System.Console.WriteLine(buffer);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void log(char[] buffer, int index, int count)
        {
            System.Console.WriteLine(buffer, index, count);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void log(decimal value)
        {
            System.Console.WriteLine(value);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void log(double value)
        {
            System.Console.WriteLine(value);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void log(float value)
        {
            System.Console.WriteLine(value);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void log(int value)
        {
            System.Console.WriteLine(value);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void log(uint value)
        {
            System.Console.WriteLine(value);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void log(long value)
        {
            System.Console.WriteLine(value);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void log(ulong value)
        {
            System.Console.WriteLine(value);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void log(object value)
        {
            System.Console.WriteLine(value);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void log(string value)
        {
            System.Console.WriteLine(value);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void log(string format, object arg0)
        {
            System.Console.WriteLine(format, arg0);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void log(string format, object arg0, object arg1)
        {
            System.Console.WriteLine(format, arg0, arg1);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void log(string format, object arg0, object arg1, object arg2)
        {
            System.Console.WriteLine(format, arg0, arg1, arg2);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void log(string format, params object[] arg)
        {
            if (arg == null)
                System.Console.WriteLine(format, null, null);
            else
                System.Console.WriteLine(format, arg);
        }
    }
}