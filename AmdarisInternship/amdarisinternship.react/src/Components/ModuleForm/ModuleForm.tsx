import React from "react";
import Container from "@material-ui/core/Container";
import FormControl from '@material-ui/core/FormControl';
import InputLabel from "@material-ui/core/InputLabel";
import Input from "@material-ui/core/Input";
import FormHelperText from "@material-ui/core/FormHelperText";

export default function moduleForm() {
    return (
        <React.Fragment>
            <Container maxWidth="md">
                <FormControl>
                    <InputLabel htmlFor="my-input">Module name</InputLabel>
                    <Input id="my-input" aria-describedby="my-helper-text" />
                </FormControl>







                {/* <Typography variant="h4">
                    Add module
                </Typography>

                <Typography variant="h6">
                    Please complete the form. Mandatory fields are marked with a *
                </Typography>

                <Grid container spacing={3}>
                    <Grid item xs={12} sm={3}>
                        <Typography variant="h6">
                            Module name
                        </Typography>
                    </Grid>

                    <Grid item xs={12} sm={6}>
                        <TextField
                            required
                            id="moduleName"
                            name="Module name"
                            label="Module name"
                            fullWidth
                            autoComplete="given-name"
                        />
                    </Grid>
                </Grid> */}


            </Container>
        </React.Fragment>
    );
}