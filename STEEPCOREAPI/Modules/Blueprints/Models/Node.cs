using STEEPCOREAPI.Shared.Models;

namespace STEEPCOREAPI.Modules.Blueprints.Models;

public class FlowchartNode
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Label { get; set; } = string.Empty;
    public FlowchartNodeType Type { get; set; } = FlowchartNodeType.Default;
    public double PositionX { get; set; }
    public double PositionY { get; set; }
    public string? Description { get; set; }
    public Guid BlueprintId { get; set; }
    public Blueprint? Blueprint { get; set; }
}
