namespace Kanonji.SmallExperiment.GameObjectInStaticVariable {

	public struct BazStruct {

		public string foo;
		private string bar;

		public BazStruct(string foo, string bar) {
			this.foo = foo;
			this.bar = bar;
		}

		public string GetBar() {
			return this.bar;
		}

		public static BazStruct Init() {
			return new BazStruct("foo", "bar");
		}
	}
}
