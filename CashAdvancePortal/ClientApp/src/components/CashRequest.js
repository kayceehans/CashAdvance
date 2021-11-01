import { post } from 'jquery';
import React, { Component } from 'react';
import { Container, Row, Col } from 'reactstrap';
import { Button, Form, FormGroup, Label, Input } from 'reactstrap';
import CardHeader from './CardHeader'

export class CashRequest extends Component {
    constructor(props) {
        super(props);
        this.handleSubmit = this.handleSubmit.bind(this);
       // this.handleChange = this.handleChange.bind(this);        

    }
    
   async handleSubmit(event) {
        debugger
        event.preventDefault();
        const data = new FormData(event.target);
                   
        await fetch('api/cashadvance/RequestCash', {
           method: 'POST',
           body: data,
       }).
            then((response) => response.json()).
            then((responseJson) => {
                if (responseJson == true) {
                    alert("Congratulations!,Cash Advance raised successfully. Awaiting approval");
                }
                alert("Session expired!");
                debugger
               this.props.history.push("/");
           });
    }
    
    
    render() {
        return (
            <>
                <div >
                    <Container>
                        <CardHeader Title="Cash Advance Form" Description="Enter Details accordingly and make sure all facts are correct." />
                        <form onSubmit={this.handleSubmit} >
                        <Row>
                            <Col sm="4">
                                <Label for="EmployeeName">Employee Name</Label>
                                    <Input type="text" name="NameOfEmployee"  id="EmployeeName" />
                            </Col>
                            <Col sm="4">
                                <FormGroup>
                                    <Label for="Department">Department</Label>
                                        <Input type="select" name="Department" id="exampleSelect">
                                        <option>--select Department--</option>
                                        <option>HCM</option>
                                        <option>I-T</option>
                                        <option>Legal</option>
                                        <option>Operations</option>                                        
                                    </Input>
                                </FormGroup>
                            </Col>
                            <Col sm="4">
                                <Label for="Amount">Amount</Label>
                                <Input type="text" name="Amount" id="Amount" />
                            </Col>
                        </Row>
                        <Row>
                            <Col sm="4">
                                <Label for="Supervisors">Supervisors Name</Label>
                                    <Input type="text" name="SupervisorName" id="Supervisors" />
                            </Col>
                            <Col sm="8">
                                <FormGroup>
                                    <Label for="Justification">Reason for Cash Advance</Label>
                                        <Input type="text" name="CashAdvancePurpose" id="Justification" />
                                </FormGroup>
                            </Col>
                        </Row>
                       
                        <Row>
                            <Col xs="6">&nbsp;</Col>
                            <Col xs="6">&nbsp;</Col>
                        </Row>
                        <Row>
                            <Col xs="6" sm="4"></Col>
                            <Col sm="4"><Button color="primary" size="lg" active>Submit Request</Button>{' '}</Col>
                            <Col sm="4"></Col>
                            </Row>
                            </form>
                    </Container>
                </div>
            </>
        );
    }
}
