using System;
using Newtonsoft.Json;

namespace SportClubISS.Models;

public class Specialization : IEquatable<Specialization>
{
    [JsonProperty("id")] public Guid Id { get; }
    [JsonProperty("title")] private string _title;
    public string Title => _title;

    [JsonConstructor]
    public Specialization([JsonProperty("id")] Guid id, [JsonProperty("title")] string title)
    {
        Id = id;
        _title = title;
    }


    public bool Equals(Specialization? other)
    {
        if (other == null)
            return false;

        return Id.Equals(other.Id);
    }
}