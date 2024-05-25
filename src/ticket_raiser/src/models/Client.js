const { sql } = require('../db');

class Client {
    static async getAll() {
        const result = await sql.query`SELECT * FROM Client`;
        return result.recordset;
    }

    static async create(client) {
        const result = await sql.query`
            INSERT INTO Client (Name, ContactInformation, AccountedFor)
            VALUES (${client.name}, ${client.contactInformation}, ${client.accountedFor})
        `;
        return result.rowsAffected;
    }
}

module.exports = Client;
