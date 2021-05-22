using OpenTK.Graphics.OpenGL;

namespace ConsoleApp3
{
    class Silla
    {
        public Silla() { }

        public void Dibujar()
        {
            //asiento
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.60f, 0.60f);
            GL.Vertex2(0.0, 0.0);
            GL.Vertex2(0.2, 0.2);
            GL.Vertex2(0.0, 0.4);
            GL.Vertex2(-0.2, 0.2);
            GL.End();


            //espaldar

            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.50f, 0.50f);
            GL.Vertex2(-0.2, 0.2);
            GL.Vertex2(0.0, 0.4);
            GL.Vertex2(0.0, 0.8);
            GL.Vertex2(-0.2, 0.6);
            GL.End();


            ///Barrita del Asiento Adelante
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.50f, 0.55f);
            GL.Vertex2(0.0, 0.0);
            GL.Vertex2(0.2, 0.2);
            GL.Vertex2(0.2, 0.15);
            GL.Vertex2(0.0, -0.05);
            GL.End();


            //Barrita del Asiento Detras
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.50f, 0.55f);
            GL.Vertex2(0.0, 0.0);
            GL.Vertex2(-0.2, 0.2);
            GL.Vertex2(-0.2, 0.15);
            GL.Vertex2(0.0, -0.05);
            GL.End();


            //Pata del Medio
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.70f, 0.70f);
            GL.Vertex2(0.0, -0.05);
            GL.Vertex2(0.0, -0.2);
            GL.Vertex2(0.02, -0.18);
            GL.Vertex2(0.02, -0.03);
            GL.End();


            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.40f, 0.40f);
            GL.Vertex2(0.0, -0.05);
            GL.Vertex2(0.0, -0.2);
            GL.Vertex2(-0.02, -0.18);
            GL.Vertex2(-0.02, -0.03);
            GL.End();


            ///Pata de la Derecha
            ///

            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.70f, 0.70f);
            GL.Vertex2(0.2, 0.15);
            GL.Vertex2(0.2, -0.05);
            GL.Vertex2(0.18, -0.07);
            GL.Vertex2(0.18, 0.13);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.40f, 0.40f);
            GL.Vertex2(0.18, -0.07);
            GL.Vertex2(0.16, -0.05);
            GL.Vertex2(0.16, 0.11);
            GL.Vertex2(0.18, 0.13);
            GL.End();



            ///Patas del Lado Izquierdo
            ///

            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.40f, 0.40f);
            GL.Vertex2(-0.2, 0.15);
            GL.Vertex2(-0.2, 0.0);
            GL.Vertex2(-0.18, -0.02);
            GL.Vertex2(-0.18, 0.13);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.70f, 0.70f);
            GL.Vertex2(-0.18, -0.02);
            GL.Vertex2(-0.16, 0.0);
            GL.Vertex2(-0.16, 0.11);
            GL.Vertex2(-0.18, 0.13);
            GL.End();
        }
    }
}
