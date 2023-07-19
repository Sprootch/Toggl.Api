﻿using System.Collections.Generic;

namespace Toggl.Api.DataObjects;

using Newtonsoft.Json;

public class ReportTimeEntry : BaseDataObject
{
	[JsonProperty(PropertyName = "id")]
	public long? Id { get; set; }

	[JsonProperty(PropertyName = "pid")]
	public long? ProjectId { get; set; }

	[JsonProperty(PropertyName = "project")]
	public string? ProjectName { get; set; }

	[JsonProperty(PropertyName = "client")]
	public string? ClientName { get; set; }

	[JsonProperty(PropertyName = "tid")]
	public long? TaskId { get; set; }

	[JsonProperty(PropertyName = "task")]
	public string? TaskName { get; set; }

	[JsonProperty(PropertyName = "uid")]
	public long? UserId { get; set; }

	[JsonProperty(PropertyName = "user")]
	public string? UserName { get; set; }

	[JsonProperty(PropertyName = "description")]
	public string? Description { get; set; }

	[JsonProperty(PropertyName = "start")]
	public string? Start { get; set; }

	[JsonProperty(PropertyName = "end")]

	public string? Stop { get; set; }

	[JsonProperty(PropertyName = "dur")]
	public long? Duration { get; set; }

	[JsonProperty(PropertyName = "updated")]

	public string? Updated { get; set; }

	[JsonProperty(PropertyName = "use_stop")]
	public bool? UseStop { get; set; }

	[JsonProperty(PropertyName = "is_billable")]
	public bool? IsBillable { get; set; }

	[JsonProperty(PropertyName = "billable")]
	public long? Billable { get; set; }

	[JsonProperty(PropertyName = "tags")]
	public List<string>? TagNames { get; set; }

	public override string ToString() => string.Format("Id: {0}, Start: {1}, Stop: {2}, TaskId: {3}", Id, Start, Stop, TaskId);
}