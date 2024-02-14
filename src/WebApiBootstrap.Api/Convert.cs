namespace WebApiBootstrap.Api;

internal static class Convert
{
    /// <summary>
    ///     Converts an object to a data transfer object (DTO).
    /// </summary>
    /// <param name="serializable">The object to convert.</param>
    /// <typeparam name="T">The type of DTO.</typeparam>
    /// <returns>The DTO.</returns>
    /// <remarks>
    ///     This method is a shorthand for <see cref="ISerializableAs{T}.ToDto" />. It allows using the method group syntax:
    ///     <code> var dtos = models.Select(Convert.ToDto); </code>
    ///     instead of the lambda syntax:
    ///     <code> var dtos = models.Select(model => model.ToDto()); </code>
    /// </remarks>
    /// <seealso cref="ISerializableAs{T}" />
    public static T ToDto<T>(this ISerializableAs<T> serializable)
    {
        return serializable.ToDto();
    }
}