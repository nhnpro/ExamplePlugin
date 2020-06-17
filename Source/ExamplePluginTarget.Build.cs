using Flax.Build;

public class ExamplePluginTarget : GameTarget
{
    /// <inheritdoc />
    public override void Init()
    {
        base.Init();

        // Reference the modules for game
        Modules.Add("ExamplePlugin");
    }
}
