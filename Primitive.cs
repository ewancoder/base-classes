namespace Lifestyle.Shared
{
    using System;

    /// <summary>
    /// Primitive.
    /// </summary>
    /// <typeparam name="TValue">Primitive value type.</typeparam>
    public abstract class Primitive<TValue>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Primitive{TValue}"/>
        /// class.
        /// </summary>
        /// <param name="value">Primitive value.</param>
        protected Primitive(TValue value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            Value = value;
        }

        /// <summary>
        /// Primitive value.
        /// </summary>
        public TValue Value { get; }

        /// <summary>
        /// Gets primitive value's hash code.
        /// </summary>
        /// <returns>Primitive value's hash code.</returns>
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        /// <summary>
        /// Tests equality between values of primitives.
        /// </summary>
        /// <param name="obj">Other primitive.</param>
        /// <returns>Result of the equality check.</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, null))
                return false;

            if (ReferenceEquals(obj, this))
                return true;

            if (obj is Primitive<TValue> primitive)
                return Value.Equals(primitive.Value);

            return false;
        }

        /// <summary>
        /// Gets string representation of primitive value.
        /// </summary>
        /// <returns>Primitive value.</returns>
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
