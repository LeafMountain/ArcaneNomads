﻿using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public struct PlayerComponent : IComponentData { }

public class PlayerComponentWrapper : ComponentDataWrapper<PlayerComponent> {}