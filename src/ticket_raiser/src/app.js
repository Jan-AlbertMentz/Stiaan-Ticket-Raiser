const express = require('express');
const bodyParser = require('body-parser');
const clientRoutes = require('./routes/clientRoutes');
const { connectToDatabase } = require('./db');

const app = express();

app.use(bodyParser.json());
app.use('/api', clientRoutes);

const PORT = process.env.PORT || 3000;

connectToDatabase().then(() => {
    app.listen(PORT, () => {
        console.log(`Server is running on port ${PORT}`);
    });
});
