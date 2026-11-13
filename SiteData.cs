namespace ArtPage;

/// <summary>One top-level menu tab and the sub-sections shown in its dropdown.</summary>
public record NavSection(string Title, string Href, string Blurb, string[] Items);

/// <summary>
/// Edit the menu here. Every list below feeds the dropdown menus
/// and the cards on each section page automatically.
/// </summary>
public static class SiteData
{
    public static readonly string[] Shop =
        { "Commissions", "Books", "Games", "Stickers", "Posters", "Stationery", "Clothing", "Cards", "Misc" };

    public static readonly string[] Art =
        { "Illustrations", "Fanart", "Comics and skits" };

    public static readonly string[] MyWorlds =
        { "World of Kingdoms", "School", "Teens", "Tarot magical girls", "Paper OCs", "Picrew OCs", "Anti-void", "Game OCs", "Gacha OCs", "Random OCs" };

    public static readonly string[] Updates =
        { "Blog", "Latest news", "Art fight", "New works", "Changelogs" };

    public static readonly string[] About =
        { "My info", "Friends and family", "Favorite anime", "Favorite games", "Favorite songs", "Favorite shows", "Favorite movies" };

    public static readonly NavSection[] Sections =
    {
        new("Home", "", "", System.Array.Empty<string>()),
        new("Shop", "shop", "Things you can get from me: commissions, prints and more.", Shop),
        new("Art", "art", "Illustrations, fanart and little comics.", Art),
        new("My Worlds", "my-worlds", "The stories, characters and places I dream up.", MyWorlds),
        new("Updates", "updates", "News, blog posts and what I am working on.", Updates),
        new("About Me", "about", "Who I am and the things I love.", About),
    };

    /// <summary>Turns "Comics and skits" into "comics-and-skits" so menu links can jump to a card.</summary>
    public static string Slug(string text)
    {
        var chars = text.ToLowerInvariant().Select(c => char.IsLetterOrDigit(c) ? c : '-').ToArray();
        return string.Join("-", new string(chars).Split('-', StringSplitOptions.RemoveEmptyEntries));
    }
}
