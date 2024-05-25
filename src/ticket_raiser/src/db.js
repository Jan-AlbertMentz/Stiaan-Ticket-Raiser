const sql = require('mssql');

const config = {
    user: 'Stiaan', // The username you created for the SQL Server login
    password: '123', // The password for the SQL Server login
    server: 'localhost', // The server where your SQL Server instance is running, replace 'localhost' with your server's name or IP address if it's different
    database: 'StiaanTicketRaiser', // The name of your SQL Server database
    options: {
        encrypt: false, // Set to true if you're using Windows Azure
        trustServerCertificate: true // Change to false if using a trusted certificate
    }
};


async function connectToDatabase() {
    try {
        await sql.connect(config);
        console.log('Connected to the database');
    } catch (err) {
        console.error('Database connection failed:', err);
    }
}

module.exports = {
    sql,
    connectToDatabase
};
