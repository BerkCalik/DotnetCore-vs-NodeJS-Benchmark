'use strict';
module.exports = function(app) {
  var valuest = require('../controllers/valuesController');

  app.route('/values')
    .get(valuest.list_all_tasks)
};