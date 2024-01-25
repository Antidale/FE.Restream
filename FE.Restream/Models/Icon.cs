using FE.Restream.Enums;

namespace FE.Restream.Models
{
    public class Icon(IconType type, IconState state = IconState.Gray)
    {
        public string Class { get => type.ToString(); }
        public string Name { get; private set; } = $"{type}-{state}.png";

        public void HandleClick()
        {
            state = state switch
            {
                IconState.Gray => IconState.Color,
                IconState.Color => IconState.Check,
                IconState.Check => IconState.Gray,
                _ => IconState.Gray
            };

            Name = UpdateName();
        }

        private string UpdateName() => $"{type}-{state}.png";

    }
}
