using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace CG_3
{
    public partial class Form1 : Form
    {
        private List<Parallelepiped> _objects;

        private DateTime _lastTime;
        private float[] rotate = { 0, 0};

        private bool _mouseDown;
        private Point _mousePosition;
        private float _intensivity = 0.1f;
        private int[] _direction = { 0,0,0};

        private float[] _lightPos = { 3, 1, 1, 0 };

        private Thread _renderThread;
        private float[]  _playerPos = { 0f, 0f, 3f};
        private Dictionary<Keys, (int, int)> _keyDirect;

        private float _deltaTime => (float)(DateTime.Now - _lastTime).TotalSeconds;

        public Form1()
        {
            InitializeComponent();
            glControl1.MouseDown += (a, e) =>
            {
                _mouseDown = true;
                _mousePosition = MousePosition;
            };

            glControl1.MouseUp += (a, e) => _mouseDown = false;

            Application.Idle += Update;

            glControl1.KeyDown += KeyDownAction;

            glControl1.KeyUp += KeyUpAction;

            FormClosing += (a, e) =>
            {
                _renderThread.Abort();
            };

        }

        private void Update(object a, EventArgs e)
        {
            if (_mouseDown)
            {
                rotate[1] += (_mousePosition.X - MousePosition.X) * _intensivity;
                rotate[0] += (_mousePosition.Y - MousePosition.Y) * _intensivity;
                _mousePosition = MousePosition;
            }
        }

        private void KeyDownAction(object a, KeyEventArgs e)
        {
            try
            {
                var k = _keyDirect[e.KeyCode];
                _direction[k.Item1] = k.Item2;
            }
            catch { }
        }


        private void KeyUpAction(object a, KeyEventArgs e)
        {
            try
            {
                var k = _keyDirect[e.KeyCode];
                _direction[k.Item1] = 0;
            }
            catch { }
        }

        private void MoveCamera()
        {
            GL.Rotate(rotate[0], 1, 0, 0);
            GL.Rotate(rotate[1], 0, 0, 1);
            GL.Translate(-_playerPos[0], -_playerPos[1], -_playerPos[2]);
        }

        private void DrawObjects(Parallelepiped parallelepiped)
        {
            GL.VertexPointer(3, VertexPointerType.Float, 0, parallelepiped.Vertices);
            GL.NormalPointer(NormalPointerType.Float, 0, parallelepiped.Normals);
            GL.Color4(parallelepiped.Color.R/255f, parallelepiped.Color.G/255f, parallelepiped.Color.B/255f, parallelepiped.Color.A / 255f);
            GL.DrawArrays(PrimitiveType.Triangles, 0, parallelepiped.Vertices.Length/3);
        }

        private void Init()
        {
            _keyDirect = new Dictionary<Keys, (int, int)>();
            _keyDirect[Keys.W] = (1, 1);
            _keyDirect[Keys.S] = (1, -1);
            _keyDirect[Keys.D] = (0, 1);
            _keyDirect[Keys.A] = (0, -1);
            _keyDirect[Keys.Space] = (2, 1);
            _keyDirect[Keys.ShiftKey] = (2, -1);

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Frustum(-1, 1, -1, 1, 2, 80);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            GL.Enable(EnableCap.DepthTest);
            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);
            GL.Enable(EnableCap.Lighting);
            GL.Enable(EnableCap.Light0);
            GL.Enable(EnableCap.ColorMaterial);

            GL.Viewport(0, 0, glControl1.ClientSize.Width, glControl1.ClientSize.Height);
            GL.Light(LightName.Light0, LightParameter.Position, _lightPos);
        }


        private void glControl1_Load(object sender, EventArgs e)
        {
            _objects = new List<Parallelepiped>();
            glControl1.MakeCurrent();

            Init();

            RenderCycle();

            glControl1.Context.MakeCurrent(null);
            _renderThread = new Thread(() =>
            {
                glControl1.Context.MakeCurrent(glControl1.WindowInfo);
                while (Application.RenderWithVisualStyles) { Draw(); }
            });
            _renderThread.Start();
        }

        private void DeleteObject(object a, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Delete)
            {
                List<int> wantdel = new List<int>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Selected)
                        wantdel.Add(row.Index);
                }

                wantdel.OrderByDescending(y => y).ToList().ForEach(x =>
                {
                    dataGridView1.Rows.RemoveAt(x);
                    _objects.RemoveAt(x);
                });
            }
        }

        private void RenderCycle()
        {
            var ang = rotate[1] * Math.PI / 180;
            _playerPos[0] += (float)(Math.Sin(ang) * _direction[1] * _deltaTime + Math.Cos(ang) * _direction[0] * _deltaTime);
            _playerPos[1] += (float)(-Math.Sin(ang) * _direction[0] * _deltaTime + Math.Cos(ang) * _direction[1] * _deltaTime);
            _playerPos[2] += _direction[2] * _deltaTime;

            glControl1.MakeCurrent();

            GL.ClearColor(0, 0, 0, 0);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.PushMatrix();
            MoveCamera();
            GL.Enable(EnableCap.VertexArray);
            GL.Enable(EnableCap.NormalArray);
            GL.Light(LightName.Light0, LightParameter.Position, _lightPos);
            foreach (var obj in _objects)
            {
                DrawObjects(obj);
            }
            GL.DisableClientState(ArrayCap.VertexArray);
            GL.DisableClientState(ArrayCap.NormalArray);

            GL.PopMatrix();
            glControl1.SwapBuffers();
            _lastTime = DateTime.Now;
        }

        private void Draw()
        {
            RenderCycle();
            Thread.Sleep(20);
        }

        private void _colorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                _colorButton.BackColor = colorDialog1.Color;
            }
        }

        private void _addButton_Click(object sender, EventArgs e)
        {
            try
            {
                var pos = new OpenTK.Vector3(float.Parse(_positionX.Text), float.Parse(_positionY.Text), float.Parse(_positionZ.Text));
                var scale = new OpenTK.Vector3(float.Parse(_scaleX.Text), float.Parse(_scaleY.Text), float.Parse(_scaleZ.Text));
                var butColor = _colorButton.BackColor;
                var color = System.Drawing.Color.FromArgb(int.Parse(_alpha.Text), butColor.R, butColor.G, butColor.B);
                var obj = new Parallelepiped(pos, scale, color);
                _objects.Add(obj);
                var bm = new Bitmap(40, 40);
                for (int i = 0; i < 40; i++)
                {
                    for (int j = 0; j < 40; j++)
                    {
                        bm.SetPixel(i, j, obj.Color);
                    }
                }
                dataGridView1.Rows.Add($"X:{obj.Position.X}, Y:{obj.Position.Y}, Z:{obj.Position.Z}", $"X:{obj.Scale.X}, Y:{obj.Scale.Y}, Z:{obj.Scale.Z}", bm);
            }
            catch { }
        }
    }
}
