using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    class SportBike : Motorcycle
    {
        
        internal void SportBikeMethod()
        {
            string power = $"150 {enginePower}";
            string volue = $"500 {engineVolumeValue}";
            string type = engineType;
            //string powerPrivate = enginePowerPrivate; не доступен

            maxSpeedInternal = 300;
            maxSpeedProtected = 300;
            maxSpeedProtectedInternal = 300;
            maxSpeedProtectedPrivate = 300;
            maxSpeedPublic = 300;
            //maxSpeedPrivate не доступен

            engineVolumeInternal = 500;
            engineVolumeProtected = 500;
            engineVolumeProtectedInternal = 500;
            engineVolumeProtectedPrivate = 500;
            engineVolumePublic = 500;
            //engineVolumePrivate не доступен

            odometrValueInternal = 999;
            odometrValueProtected = 999;
            odometrValueProtectedInternal = 999;
            odometrValueProtectedPrivate = 999;
            odometrValuePublic = 999;
            //engineVolumePrivate не доступен

            MotoInternal();
            MotoProtected();
            MotoProtectedInternal();
            MotoProtectedPrivate();
            MotoPublic();
            //MotoPrivate() не доступен
        }
    }
}
