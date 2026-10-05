using SPTarkov.Common.Models.Logging;
using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;
using SPTarkov.Server.Core.Models.Spt.Tables;

namespace KnightMaskFix;

[Injectable(TypePriority = int.MaxValue)]
public class MaskFixPlugin(
    ISptLogger<MaskFixPlugin> logger,
    TemplateTable templateTable)
    : IOnLoad
{
    private const string KnightMaskId = "62963c18dbc8ab5f0d382d0b";

    public Task OnLoadAsync(CancellationToken cancellationToken)
    {
        FixKnightMask();
        logger.Success("[KnightMaskFix] Loaded successfully!");
        return Task.CompletedTask;
    }

    private void FixKnightMask()
    {
        var items = templateTable.Items;

        if (items.TryGetValue(KnightMaskId, out var mask) && mask?.Properties?.Prefab != null)
        {
            mask.Properties.Prefab.Path = "maskfix.bundle";
            mask.Properties.Prefab.Rcid = "";

            logger.Success($"[KnightMaskFix] Successfully repointed {KnightMaskId} to maskfix.bundle");
        }
        else
        {
            logger.Error("[KnightMaskFix] Could not find Knight mask or Prefab object in database!");
        }
    }
}