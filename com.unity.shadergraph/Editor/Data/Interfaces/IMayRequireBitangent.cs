using UnityEditor.Graphing;

namespace UnityEditor.ShaderGraph
{
    public interface IMayRequireBitangent
    {
        NeededCoordinateSpace RequiresBitangent();
    }

    public static class MayRequireBitangentExtensions
    {
        public static NeededCoordinateSpace RequiresBitangent(this ISlot slot)
        {
            var mayRequireBitangent = slot as IMayRequireBitangent;
            return mayRequireBitangent != null ? mayRequireBitangent.RequiresBitangent() : NeededCoordinateSpace.None;
        }
    }
}
