import { Alert } from 'bootstrap';
import React, { Component } from 'react';

export class ViewCashAdvance extends Component {
   //dddd static displayName = FetchData.name;

    constructor(props) {
        super(props);
        this.state = { cash: [] };
        this.handleApprove = this.handleApprove.bind(this);
        this.handleReject = this.handleReject(this);
    }

    componentDidMount() {
        this.populateCashAvanceData();
    }    

    render() {       

        return (
            <div>                
                <p>Cash Advance Table.</p>
                <table className='table table-striped' aria-labelledby="tabelLabel">
                    <thead>
                        <tr>
                            <th>Name Of Employee</th>
                            <th>Department</th>
                            <th>Amount</th>                           
                            <th>SupervisorName</th>
                            <th>CashAdvancePurpose</th>
                            <th>RequestID</th>                           
                         </tr>
                    </thead>
                    <tbody>
                        {this.state.cash.map(item =>
                            <tr key={item.id}>
                                <td>{item.nameOfEmployee}</td>
                                <td>{item.department}</td>
                                <td>{item.amount}</td>                               
                                <td>{item.supervisorName}</td>
                                <td>{item.cashAdvancePurpose}</td>
                                <td>{item.requestID}</td>                              
                               
                                <td>
                                    <a className="action" onClick={(id) => this.handleApprove(item.RequestID)}>Approve</a> |
                                   <a className="action" onClick={(id) => this.handleReject(item.RequestID)}>Reject</a>
                                </td>
                            </tr>
                        )}
                    </tbody>                   
                </table>
            </div>
        );
    }

    async populateCashAvanceData() {
        const response = await fetch('api/cashadvance/CashRequest');
        const data = await response.json();
        if (!(data.length > 0)) {
            alert("No Records!");
        }
        debugger
        var ListResp = [];
        for (var i = 0; i < data.length; i++) {
            ListResp.push(data[i]);           
        }
        this.setState({
            cash: ListResp
        });
        debugger           
    }
    handleApprove(reqID) {

    }
    handleReject(reqID) {

    }
}
