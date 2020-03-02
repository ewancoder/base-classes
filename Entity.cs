namespace Lifestyle.Shared
{
    /// <summary>
    /// Entity.
    /// </summary>
    /// <typeparam name="TId">Identity type.</typeparam>
    public abstract class Entity<TId>
    {
        /// <summary>
        /// Gets entity identity.
        /// </summary>
        /// <returns>Entity identity.</returns>
        protected abstract TId GetIdentity();

        /// <summary>
        /// Gets entity identity's hash code.
        /// </summary>
        /// <returns>Entity identity's hash code.</returns>
        public override int GetHashCode()
        {
            return GetIdentity().GetHashCode();
        }

        /// <summary>
        /// Tests equality between identities of entities. Also checks that both
        /// entities are the same type.
        /// </summary>
        /// <param name="obj">Other entity.</param>
        /// <returns>Result of the equality check.</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, null))
                return false;

            if (ReferenceEquals(obj, this))
                return true;

            if (obj is Entity<TId> entity)
            {
                if (GetType() != obj.GetType())
                    return false;

                return GetIdentity().Equals(entity.GetIdentity());
            }

            return false;
        }
    }
}
