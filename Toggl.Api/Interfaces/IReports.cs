﻿using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Toggl.Api.Models;

namespace Toggl.Api.Interfaces;

public interface IReports
{
	/// <summary>
	/// Returns summary user projects.
	/// https://engineering.toggl.com/docs/reports/summary_reports#post-list-project-users
	/// </summary>
	/// <param name="workspaceId">The workspace id</param>
	/// <param name="reportRequest">The report request</param>
	/// <param name="cancellationToken">The cancellation token</param>
	/// <returns></returns>
	[Post("/reports/api/v3/workspace/{workspace_id}/projects/summary")]
	Task<ICollection<WorkspaceProjectReportItem>> GetWorkspaceProjectSummaryAsync(
		[AliasAs("workspace_id")] long workspaceId,
		[Body] ReportRequest reportRequest,
		CancellationToken cancellationToken
		);

	/// <summary>
	/// Returns project's summary.
	/// https://engineering.toggl.com/docs/reports/summary_reports#post-load-project-summary
	/// </summary>
	/// <param name="workspaceId">The workspace id</param>
	/// <param name="projectId">The project id</param>
	/// <param name="reportRequest">The report request</param>
	/// <param name="cancellationToken">The cancellation token</param>
	/// <returns></returns>
	[Post("/reports/api/v3/workspace/{workspace_id}/projects/{project_id}/summary")]
	Task<ProjectSummaryReportItem> GetProjectSummaryAsync(
		[AliasAs("workspace_id")] long workspaceId,
		[AliasAs("project_id")] long projectId,
		[Body] ReportRequest reportRequest,
		CancellationToken cancellationToken
		);
}