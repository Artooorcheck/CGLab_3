using OpenTK;
using System.Drawing;

namespace CG_3
{
    class Parallelepiped
    {
        private Vector3 _position;
        private Vector3 _scale;

        public Color Color { get; private set; }

        public Vector3 Scale
        {
            get => _scale;
            set
            {
                _scale = value;
                GenerateVertices();
            }
        }


        public Vector3 Position
        {
            get => _position;
            set
            {
                _position = value;
                GenerateVertices();
            }
        }

        public float[] Vertices { get; private set; }
        public float[] Normals { get; private set; }

        public float[] Temp => template;

        public Parallelepiped(Vector3 position, Vector3 scale, Color color)
        {
            _scale = scale;
            _position = position;
            Color = color;
            GenerateVertices();
        }

        private void GenerateVertices()
        {
            if (Vertices == null)
            {
                Vertices = new float[108];
                Normals = new float[108];
            }
            Vector3 minPos = new Vector3(_position.X - _scale.X / 2, _position.Y - _scale.Y / 2, _position.Z - _scale.Z / 2);
            Vector3 maxPos = new Vector3(_position.X - _scale.X / 2, _position.Y - _scale.Y / 2, _position.Z - _scale.Z / 2);
            for (int i = 0; i < 36; i++)
            {
                Vertices[i * 3] = _position.X + template[i * 3] * _scale.X / 2;
                Vertices[i * 3 + 1] = _position.Y + template[i * 3 + 1] * _scale.Y / 2;
                Vertices[i * 3 + 2] = _position.Z + template[i * 3 + 2] * _scale.Z / 2;
            }

            for (int i = 0; i < 36; i++)
            {
                var normal = new Vector3(Vertices[i * 3] - Position.X, Vertices[i * 3 + 1] - Position.Y, Vertices[i * 3 + 2] - Position.Z).Normalized();
                Normals[i * 3] = normal.X;
                Normals[i * 3 + 1] = normal.Y;
                Normals[i * 3 + 2] = normal.Z;
            }
        }


        float[] template = {
                -1.0f,-1.0f,-1.0f,
                -1.0f,-1.0f, 1.0f,
                -1.0f, 1.0f, 1.0f,
                1.0f, 1.0f,-1.0f,
                -1.0f,-1.0f,-1.0f,
                -1.0f, 1.0f,-1.0f,
                1.0f,-1.0f, 1.0f,
                -1.0f,-1.0f,-1.0f,
                1.0f,-1.0f,-1.0f,
                1.0f, 1.0f,-1.0f,
                1.0f,-1.0f,-1.0f,
                -1.0f,-1.0f,-1.0f,
                -1.0f,-1.0f,-1.0f,
                -1.0f, 1.0f, 1.0f,
                -1.0f, 1.0f,-1.0f,
                1.0f,-1.0f, 1.0f,
                -1.0f,-1.0f, 1.0f,
                -1.0f,-1.0f,-1.0f,
                -1.0f, 1.0f, 1.0f,
                -1.0f,-1.0f, 1.0f,
                1.0f,-1.0f, 1.0f,
                1.0f, 1.0f, 1.0f,
                1.0f,-1.0f,-1.0f,
                1.0f, 1.0f,-1.0f,
                1.0f,-1.0f,-1.0f,
                1.0f, 1.0f, 1.0f,
                1.0f,-1.0f, 1.0f,
                1.0f, 1.0f, 1.0f,
                1.0f, 1.0f,-1.0f,
                -1.0f, 1.0f,-1.0f,
                1.0f, 1.0f, 1.0f,
                -1.0f, 1.0f,-1.0f,
                -1.0f, 1.0f, 1.0f,
                1.0f, 1.0f, 1.0f,
                -1.0f, 1.0f, 1.0f,
                1.0f,-1.0f, 1.0f
        };
    }
}
