﻿namespace TagzApp.Common;

public class Content
{
	/// <summary>
	/// Unique identifier for the content
	/// </summary>
	public int Id { get; internal set; }

	/// <summary>
	/// Provider that the content came from
	/// </summary>
	public string ProviderId { get; set;	}

	/// <summary>
	/// Type of the content identifier
	/// </summary>
	public ContentType Type { get; set; } = ContentType.Message;

	/// <summary>
	/// Original source of this content
	/// </summary>
	public Uri SourceUri { get; set; }

	/// <summary>
	/// Date and time when the content was created
	/// </summary>
	public DateTimeOffset Timestamp { get; set; }

	/// <summary>
	/// The account who created the content
	/// </summary>
	public Creator Author { get; set; }

	/// <summary>
	/// Text associated with this content
	/// </summary>
	public string Text { get; set; }

}