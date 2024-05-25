const Client = require('../models/Client');

exports.getClients = async (req, res) => {
    try {
        const clients = await Client.getAll();
        res.status(200).json(clients);
    } catch (err) {
        res.status(500).json({ message: err.message });
    }
};

exports.createClient = async (req, res) => {
    try {
        const client = req.body;
        const result = await Client.create(client);
        res.status(201).json(result);
    } catch (err) {
        res.status(500).json({ message: err.message });
    }
};