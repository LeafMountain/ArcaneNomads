public interface IAIState {

	AIController Controller { get; set; }
	void Enter();
	void Exit();
	void Update();
}
