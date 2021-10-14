import React, { Component } from "react";
import { Table } from "react-bootstrap";

import { Button, ButtonToolbar } from "react-bootstrap";
import { AddEmpModal } from "../../AddEmpModal";
import { EditEmpModal } from "../../EditEmpModal";

export class Issue extends Component {
  constructor(props) {
    super(props);
    this.state = { issues: [], addModalShow: false, editModalShow: false };
  }

  refreshList() {
    fetch(
      process.env.REACT_APP_API +
        "jira-issues/project/11500/pKey/FULL/page/1/pageSize/100"
    )
      .then((response) => response.json())
      .then((data) => {
        this.setState({ issues: data });
      });
  }

  componentDidMount() {
    this.refreshList();
  }

  componentDidUpdate() {
    this.refreshList();
  }
  // /api/jira-issues/project/{projectId}/pKey/{pKey}/page/{page}/pageSize/{pageSize}
  deleteIssue(id) {
    if (window.confirm("Are you sure?")) {
      fetch(process.env.REACT_APP_API + "jira-issues/" + id, {
        method: "DELETE",
        header: {
          Accept: "application/json",
          "Content-Type": "application/json",
        },
      });
    }
  }
  render() {
    const { issues, issueId, pkey, reporter, assignee, timeSpent } = this.state;
    let addModalClose = () => this.setState({ addModalShow: false });
    let editModalClose = () => this.setState({ editModalShow: false });
    return (
      <div>
        <Table className="mt-4" striped bordered hover size="sm">
          <thead>
            <tr>
              <th>pKey</th>
              <th>Reporter</th>
              <th>Assignee</th>
              <th>issueStatus</th>
              <th>timeSpent</th>
              <th>resolutionDate</th>
            </tr>
          </thead>
          <tbody>
            {issues.map((issue) => (
              <tr key={issue.id}>
                <td>{issue.pkey}</td>
                <td>{issue.reporter}</td>
                <td>{issue.assignee}</td>
                <td>{issue.issueStatus}</td>
                <td>{issue.timeSpent}</td>
                <td>{issue.resolutionDate}</td>
                <td>
                  <ButtonToolbar>
                    <Button
                      className="mr-2"
                      variant="info"
                      onClick={() =>
                        this.setState({
                          editModalShow: true,
                          issueId: issue.id,
                          pkey: issue.pkey,
                          reporter: issue.reporter,
                          assignee: issue.assignee,
                          timeSpent: issue.timeSpent,
                        })
                      }
                    >
                      Edit
                    </Button>

                    <Button
                      className="mr-2"
                      variant="danger"
                      onClick={() => this.deleteIssue(issue.id)}
                    >
                      Delete
                    </Button>

                    <EditEmpModal
                      show={this.state.editModalShow}
                      onHide={editModalClose}
                      issueId={issueId}
                      pkey={pkey}
                      reporter={reporter}
                      assignee={assignee}
                      timeSpent={timeSpent}
                    />
                  </ButtonToolbar>
                </td>
              </tr>
            ))}
          </tbody>
        </Table>

        <ButtonToolbar>
          <Button
            variant="primary"
            onClick={() => this.setState({ addModalShow: true })}
          >
            Add Issue
          </Button>

          <AddEmpModal show={this.state.addModalShow} onHide={addModalClose} />
        </ButtonToolbar>
      </div>
    );
  }
}
