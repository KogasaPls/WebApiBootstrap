namespace WebApiBootstrap.Api;

/// <summary>
///     An object that can be converted to a data transfer object (DTO) of type <typeparamref name="T" />.
/// </summary>
/// <typeparam name="T">The type of DTO.</typeparam>
internal interface ISerializableAs<out T>
{
    T ToDto();
}