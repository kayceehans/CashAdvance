﻿import React, { Component } from 'react';
import { FormGroup} from 'reactstrap';
import { Card, CardTitle, CardText } from 'reactstrap';
import { Alert } from 'reactstrap';
import { Row, Col } from 'reactstrap';

export default class CardHeader extends Component {

    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div>
                <Row>
                    <Col>
                        <FormGroup className="mb-2 mr-sm-2 mb-sm-0  text-center">
                            <Card body style={{
                                backgroundImage: `url("data:image/png;base64,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")`,
                                backgroundRepeat: 'no-repeat', backgroundsize: '200px'
                            }}>
                                <CardTitle tag="h5">{this.props.Title}</CardTitle>
                                <CardText>{this.props.Description}</CardText>

                            </Card>
                        </FormGroup>
                    </Col>
                </Row>
                <Row>
                    <Col>
                        <Alert color="primary">
                        </Alert>
                    </Col>
                </Row>
            </div>
        );
    }
}
