<template>
  <section class="container">
    <div class="content">
      <label-content @loadFromLocalStorage="loadFromLocalStorage" label="Lấy JSON từ local storage" />
      <label-content  @saveToLocalStorage="saveToLocalStorage" label="Lưu vào local storage" />
      <div
        v-for="(group, index) in groups"
        :key="index"
        @click="clickHandler(group)"
      >
        <group-item-content
        :title="group.title"
        :items="group.items"
        :group-index="index"
        :active-group-index="activeGroupIndex"
        @add-item="addItemToGroup(index, $event)"
        @delete-item="deleteItem"
        @click="activateGroup(index)" />
      </div>

      <label-content label="Thêm thành phần" @add-row="addNewGroup" />
      <button @click="saveToLocalStorage">Save to Local Storage</button>
    <button @click="loadFromLocalStorage">Load from Local Storage</button>
    </div>
  </section>
</template>

<script>
import AppLogo from "~/components/AppLogo.vue";
import LabelContent from "~/components/LabelContent.vue";
import GroupItemContent from "~/components/GroupItemContent.vue";

export default {
  components: {
    AppLogo,
    LabelContent,
    GroupItemContent,
  },
  data() {
    return {
      groups: [
        {
          title: "",
          items: [
          ],
        },
      ],
      activeGroupIndex: null
    };
  },
  methods: {
    addItemToGroup(index, newItem) {
      this.groups[index].items.push(newItem);
    },

    addNewGroup() {
      const newGroup = {
        title: "New Group",
        items: [],
      };
      this.groups.push(newGroup);
    },
    clickHandler(item) {
      console.log(item);
      this.groupIndex = item.index;
    },
    deleteItem(groupIndex, itemIndex) {
      this.groups[groupIndex].items.splice(itemIndex, 1);
    },
    activateGroup(index) {
      this.activeGroupIndex = index;
    },
    saveToLocalStorage() {
      debugger
      localStorage.setItem("myObject", JSON.stringify(this.groups));
    },
    loadFromLocalStorage() {
      const savedObject = localStorage.getItem("myObject");
      if (savedObject) {
        this.groups = JSON.parse(savedObject);
      }
    },
  },
};
</script>

<style>
.container {
  position: relative;
  background: #f4f4f4;
}
.content {
  /* Auto layout */
  display: flex;
  flex-direction: column;
  align-items: flex-start;
  padding: 0px 0px 48px 450px;
  gap: 24px;
  position: absolute;
  left: 1px;
  top: 120px;
}
</style>

