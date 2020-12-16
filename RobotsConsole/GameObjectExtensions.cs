using BL.Abstr;
using System;
using BL.Impl.Robots;
using BL.Impl.Cargos;
using BL.Impl;

namespace RobotsConsole
{
    public static class GameObjectExtensions
    {
        private static string cargoView = "c ";
        private static string toxicCargoView = "tc";
        private static string spoilingCargoView = "sc";
        private static string protectedCargoView = "pc";

        private static string cyborgView = "Cb";
        private static string workerView = "W ";
        private static string brightMindView = "Bm";
        private static string emptyElementView = "  ";
        public static string GetStringView( this IGameObject gameObj)
        {
            var res = "";
            if (gameObj == null)
            {
                res = emptyElementView;
            }
            else if (gameObj.GetCompilerTimeType() == typeof(Cargo))
            {
                res = cargoView;
            }
            else if(gameObj.GetCompilerTimeType() == typeof(ToxicCargo) )
            {
                res = toxicCargoView;
            }
            else if(gameObj.GetCompilerTimeType() == typeof(SpoilableCargo) )
            {
                res = spoilingCargoView;
            }
            else if(gameObj.GetCompilerTimeType() == typeof(ProtectedCargo) )
            {
                res = protectedCargoView;
            }
            else if(gameObj.GetCompilerTimeType() == typeof(Cyborg))
            {
                res =  cyborgView;
            }
            else if(gameObj.GetCompilerTimeType() == typeof(Worker))
            {
                res = workerView;
            }
            else if(gameObj.GetCompilerTimeType() == typeof(BrightMind))
            {
                res = brightMindView;
            }
            else if(gameObj.GetCompilerTimeType() == typeof(EmptyElement))
            {
                res = emptyElementView;
            }
            return res;
        }
    }
}
