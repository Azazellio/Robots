using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Abstr
{
    public interface IFieldBuilder
    {
        public IField CreateField(int X, int Y, Robot robot);
        public IField UpdateField(IField field);
    }
}
