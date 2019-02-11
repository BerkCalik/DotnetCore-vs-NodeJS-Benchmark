exports.list_all_tasks = function(req, res) {
  const result = {
    name: "Berk Çalık",
    age: 22
  };
  res.json(result);
};