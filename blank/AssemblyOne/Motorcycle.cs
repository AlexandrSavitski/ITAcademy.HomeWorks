using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    class Motorcycle
    {
        // const тоже что и для всех полей (public, private, internal, protected, protected private, protected internal)
        public const string enginePower = "HP";
        internal const string engineType = "Gasoline";
        protected const string engineVolumeValue = "Cm3";
        private const string enginePowerPrivate = "300";

        public int maxSpeedPublic;
        public int engineVolumePublic;
        public int odometrValuePublic;

        internal int maxSpeedInternal;
        internal int engineVolumeInternal;
        internal int odometrValueInternal;

        int _maxSpeedPrivate;
        int _engineVolumePrivate;
        int _odometrValuePrivate;

        protected int maxSpeedProtected;
        protected int engineVolumeProtected;
        protected int odometrValueProtected;

        protected internal int maxSpeedProtectedInternal;
        protected internal int engineVolumeProtectedInternal;
        protected internal int odometrValueProtectedInternal;

        protected private int maxSpeedProtectedPrivate;
        protected private int engineVolumeProtectedPrivate;
        protected private int odometrValueProtectedPrivate;

        public void MotoPublic()
        {

        }
        internal void MotoInternal()
        {

        }
        protected void MotoProtected()
        {

        }
        private void MotoPrivate()
        {

        }
        protected internal void MotoProtectedInternal()
        {

        }
        protected private void MotoProtectedPrivate()
        {

        }
    }
}
