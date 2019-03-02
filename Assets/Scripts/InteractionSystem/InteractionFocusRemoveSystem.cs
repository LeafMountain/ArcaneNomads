using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

public class InteractionFocusRemoveSystem : ComponentSystem
{
    struct FocusData
    {
        public readonly int Length;
        [ReadOnly] public ComponentDataArray<InteractableFocus> interactables;
        [ReadOnly] public ComponentDataArray<Position> positions;
        public EntityArray entities;
    }

    struct InteractorData
    {
        public readonly int Length;
        [ReadOnly] public ComponentDataArray<Interactor> interactors;
        [ReadOnly] public ComponentDataArray<Position> positions;
    }

    [Inject] FocusData focusData;
    [Inject] InteractorData interactorData;

    protected override void OnUpdate()
    {
        for (int i = 0; i < interactorData.Length; i++)
        {
            for (int j = 0; j < focusData.Length; j++)
            {
                float distance = math.distance(interactorData.positions[i].Value, focusData.positions[j].Value);
                if(distance > interactorData.interactors[i].Reach)
                    PostUpdateCommands.RemoveComponent<InteractableFocus>(focusData.entities[j]);
            }
        }
    }
}