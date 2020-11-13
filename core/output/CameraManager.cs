using OpenTK.Mathematics;

namespace MutaBrains.Core.Output
{
    static class CameraManager
    {
        public static PerspectiveCamera Perspective;
        public static OrthographicCamera Orthographic;

        public static void Initialize(Vector2 size, Vector3 position)
        {
            Perspective = new PerspectiveCamera(size, position);
            Orthographic = new OrthographicCamera(size);
        }

        public static void WindowResize(Vector2 newSize)
        {
            Perspective.WindowResize(newSize);
            Orthographic.WindowResize(newSize);
        }
    }
}
