namespace Struct.Core.Extensions
{
    public static class Generic
    {
        /// <summary>
        /// This extension checks to make sure that the target
        /// being returned is always an array. If the target
        /// is null then a zero length array is returned. Use
        /// this extension when you need to insure that your
        /// data type array has been initialized.
        /// </summary>
        /// <param name="Target">Target Array</param>
        /// <returns>Populated Array or Empty Array</returns>
        public static T[] ToArrayOrEmpty<T>(this T[] Target)
        {
            return Target == null ? new T[0] : Target;
        }
    }
}
