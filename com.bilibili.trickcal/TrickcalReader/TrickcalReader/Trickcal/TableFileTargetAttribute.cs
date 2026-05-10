namespace Trickcal.Shared
{
    public class TableFileTargetAttribute : Attribute
    {
        public TableFileTargetType TargetType { get; }

        public TableFileTargetAttribute(TableFileTargetType targetType)
        {
            TargetType = targetType;
        }
    }
}