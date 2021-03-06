﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sandbox.Common.ObjectBuilders.Definitions;

namespace Sandbox.Definitions
{
    [MyDefinitionType(typeof(MyObjectBuilder_CryoChamberDefinition))]
    class MyCryoChamberDefinition : MyCockpitDefinition
    {
        public string OverlayTexture;
        public float IdlePowerConsumption;

        protected override void Init(MyObjectBuilder_DefinitionBase builder)
        {
            base.Init(builder);
            var chamberDef = builder as MyObjectBuilder_CryoChamberDefinition;
            OverlayTexture = chamberDef.OverlayTexture;
            IdlePowerConsumption = chamberDef.IdlePowerConsumption;
        }
    }
}
