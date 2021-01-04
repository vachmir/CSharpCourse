using System;
using System.Collections;
using System.Text;

namespace OOP.Interfaces
{
    // Represents modern abstractionist painting
    class Painting : IEnumerable
    {
        private readonly Shape[] shapes;

        public Painting(Shape[] shapes)
        {
            this.shapes = shapes;
        }

        public IEnumerator GetEnumerator()
        {
            return this.shapes.GetEnumerator();
            return new PaintingShapeEnumerator(this);
        }

        class PaintingShapeEnumerator : IEnumerator
        {
            private readonly Painting painting;
            private int currentShapeIndex;

            public PaintingShapeEnumerator(Painting painting)
            {
                this.painting = painting;
                this.currentShapeIndex = -1;
            }

            public object Current => this.painting.shapes[this.currentShapeIndex];

            public bool MoveNext()
            {
                ++currentShapeIndex;
                return currentShapeIndex < this.painting.shapes.Length;

                // Question: How to enumerate only over polygon shapes?
            }

            public void Reset()
            {
                this.currentShapeIndex = -1;
            }
        }

        public IEnumerable PolygonShapes()
        {
            foreach (Shape shape in this.shapes)
            {
                if (shape is IPolygon)
                {
                    yield return shape;
                }
            }
        }
    }
}
