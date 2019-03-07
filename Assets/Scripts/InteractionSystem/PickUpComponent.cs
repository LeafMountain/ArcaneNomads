using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public struct PickUp : IComponentData
{

}

public class PickUpComponent : ComponentDataProxy<PickUp> {}
