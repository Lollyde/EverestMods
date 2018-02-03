﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celeste.Mod.SecretBerrySpawner {
    [SettingName("BerrySpawner")]
    public class BerrySpawnerModuleSettings : EverestModuleSettings {
        
        public bool Spawn { get; set; } = false;

    }
}
