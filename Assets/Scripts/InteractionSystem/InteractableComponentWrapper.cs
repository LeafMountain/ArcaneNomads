﻿using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

[System.Serializable]
public struct InteractableComponent : IComponentData { }

public class InteractableComponentWrapper : ComponentDataWrapper<InteractableComponent> {}